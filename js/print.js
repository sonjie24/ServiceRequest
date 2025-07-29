function checkMark(value) {
  return value === "Yes" ? "✔️" : "";
}

async function getData(uuid) {
  try {
    const res = await fetch(`${API_BASE_URL}/get-data-main`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ uuid }),
    });

    if (!res.ok) throw new Error(`HTTP error! Status: ${res.status}`);

    const result = await res.json();
    const main = result.data[0] || {};

    mapDataToForm(main); // <-- Populate main form fields
    console.log(main);
    // SYSTEM SELECT (if options exist)
    if (main.module) {
      systemSelect.value = main.module;
      systemSelect.dispatchEvent(new Event("change")); // trigger formSelect population

      setTimeout(() => {
        formSelect.value = main.system_form_name;
        formSelect.dispatchEvent(new Event("change"));
      }, 300); // wait for formSelect to populate
    }

    // ✅ Step 1: Select department and trigger user/head population
    if (main.department) {
      departmentSelect.value = main.department;

      // ✅ Step 2: Trigger population and wait for it to finish
      departmentSelect.dispatchEvent(new Event("change"));
      setTimeout(() => {
        userSelect.value = main.user;
        headSelect.value = main.department_head;
        itHeadSelect.value = main.it_head;
      }, 300); // wait for formSelect to populate
    }
  } catch (error) {
    console.error("Fetch error:", error);
    alert("An error occurred while fetching data.");
  }
}

async function getDataDetails(uuid) {
  try {
    const res = await fetch(`${API_BASE_URL}/get-data-detail`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ uuid }),
    });

    if (!res.ok) throw new Error(`HTTP error! Status: ${res.status}`);

    const result = await res.json();
    const detailData = result.data || [];

    saveDetailDataSession(detailData);

    // Get table body element
    const tbody = document.getElementById("details_data");

    // Clear existing rows
    tbody.innerHTML = "";

    // Loop through array to create table rows
    detailData.forEach((item) => {
      const row = document.createElement("tr"); // ✅ FIX: create <tr> not item
      row.innerHTML = `
          <td><input type="text" name="data_point" value="${
            item.data_point || ""
          }" /></td>
          <td><input type="text" name="reference_field" value="${
            item.ref_field || ""
          }" /></td>
        `;
      tbody.appendChild(row);
    });

    // ✅ Optionally add a blank row for new entry
    const blankRow = document.createElement("tr");
    blankRow.innerHTML = `
        <td><input type="text" name="data_point" value="" /></td>
        <td><input type="text" name="reference_field" value="" /></td>
      `;
    tbody.appendChild(blankRow);
  } catch (error) {
    console.error("Fetch error:", error);
    alert("An error occurred while fetching data.");
  }
}

async function getDataFiles(uuid) {
  try {
    const res = await fetch(`${API_BASE_URL}/get-data-files`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ uuid }),
    });

    if (!res.ok) throw new Error(`HTTP error! Status: ${res.status}`);

    const result = await res.json();
    const sub1 = result.data || {};

    // ✅ FIXED: Correct tbody reference
    const tbody = document.getElementById("uploadedFilesBody");
    if (!tbody) {
      console.warn("⚠️ uploadedFilesBody not found in DOM.");
      return;
    }

    tbody.innerHTML = ""; // Clear existing rows

    // Normalize sub1 to array
    let sub1Array = [];
    if (Array.isArray(sub1)) {
      sub1Array = sub1;
    } else if (sub1 && typeof sub1 === "object") {
      sub1Array = [sub1];
    }

    // Create rows dynamically
    sub1Array.forEach((item) => {
      const row = document.createElement("tr");
      row.innerHTML = `
          <td>
            <a href="${item.Link || "#"}" target="_blank">
              ${item.Link || "No Link"}
            </a>
          </td>
          <td class="action-buttons">
              <button type="button" onclick="removeFile('${
                item.GDriveID
              }',this)" id="remove">Remove</button>
          </td>
        `;
      tbody.appendChild(row);
    });
  } catch (error) {
    console.error("Fetch error:", error);
    alert("An error occurred while fetching uploaded files.");
  }
}

function mapDataToForm(main) {
  const fieldMap = {
    uuid: main.uuid,
    project: main.project || "CBMIS",
    department: main.department,
    user: main.user,
    user_id: main.user_id,
    department_head: main.department_head,
    department_head_id: main.department_head_id,
    it_head: main.it_head,
    it_head_id: main.it_head_id,
    integrator: main.integrator,
    integrator_id: main.integrator_id,
    developer: main.developer,
    developer_id: main.developer_id,
    qa: main.qa,
    qa_id: main.qa_id,
    system_form_no: main.system_form_no,
    date_requested: main.date_requested,
    service_request_no: main.service_request_no,
    memo: main.memo,
    req_status: main.req_status,
    cylix_status: main.cylix_status,
    dev_status: main.dev_status,
  };

  for (const [id, value] of Object.entries(fieldMap)) {
    const input = document.getElementById(id);
    if (input) input.value = value || "";
    else console.warn(`⚠️ Element with id '${id}' not found`);
  }

  // Checkbox/priority mappings
  const checkboxMap = {
    concern_type_new: main.concern_type_new,
    concern_type_rev: main.concern_type_rev,
    concern_type_del: main.concern_type_del,
    concern_type_cos: main.concern_type_cos,
    concern_type_data: main.concern_type_data,
    concern_type_bugs: main.concern_type_bugs,
    priority_set: main.priority_set,
    committed_date: main.committed_date,
    priority_immediate: main.priority_immediate,
    priority_add: main.priority_add,
    print_option_as_req: main.print_option_as_req,
    print_out_date: main.print_out_date,
    print_option_sys_print: main.print_option_sys_print,
    system_print_date: main.system_print_date,
    print_option_modified: main.print_option_modified,
    patch_date: main.patch_date,
  };

  for (const [id, value] of Object.entries(checkboxMap)) {
    const el = document.getElementById(id);
    if (el) {
      if (el.type === "checkbox") {
        el.checked = value === "Yes";
      } else {
        el.value = value || "";
      }
    } else {
      console.warn(`⚠️ Element with id '${id}' not found`);
    }
  }
}

window.addEventListener("DOMContentLoaded", async () => {
  alert("safsf");

  const urlParams = new URLSearchParams(window.location.search);
  const uuid = urlParams.get("id");

  if (!uuid) {
    alert("No UUID provided");
    return;
  }

  try {
    await getData(uuid);
    await getDataDetails(uuid);
    await getDataFiles(uuid);
  } catch (error) {
    console.error("Failed to load print data:", error);
    alert("Error fetching record for UUID: " + uuid);
  }
});

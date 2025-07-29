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

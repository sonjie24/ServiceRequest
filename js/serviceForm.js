(() => {

  const data = JSON.parse(localStorage.getItem("functionalities"));
  const systemSelect = document.getElementById("systemSelect");
  const formSelect = document.getElementById("formSelect");
  const formNoInput = document.getElementById("system_form_no");

  const systems = data?.Functionalities || {};

  // Populate the system dropdown
  Object.keys(systems).forEach((system) => {
    const option = document.createElement("option");
    option.value = system;
    option.textContent = system;
    systemSelect.appendChild(option);
  });

  // When a system is selected, populate form dropdown
  systemSelect.addEventListener("change", () => {
    const selectedSystem = systemSelect.value;

    // Reset form dropdown and form number
    formSelect.innerHTML =
      '<option value="" disabled selected>Select Form</option>';
    formSelect.disabled = true;
    formNoInput.value = "";

    if (selectedSystem && systems[selectedSystem]) {
      formSelect.disabled = false;

      systems[selectedSystem].forEach((form) => {
        const option = document.createElement("option");
        option.value = form.name; // This will be used as system_form_name
        option.textContent = form.name;
        option.setAttribute("data-code", form.code); // system_form_no
        formSelect.appendChild(option);
      });
    }
  });

  // When a form is selected, show its code in the input
  formSelect.addEventListener("change", () => {
    const selectedOption = formSelect.options[formSelect.selectedIndex];
    const code = selectedOption.getAttribute("data-code");
    formNoInput.value = code || "";
  });

  // Add row function (global for onclick)
  window.addRow = function () {
    const tableBody = document.querySelector("#dataTable tbody");
    const newRow = document.createElement("tr");
    newRow.innerHTML = `
      <td><input type="text" name="data_point" /></td>
      <td><input type="text" name="reference_field" /></td>
    `;
    tableBody.appendChild(newRow);
  };

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

      // SYSTEM SELECT (if options exist)
      if (main.module) {
        systemSelect.value = main.module;
        systemSelect.dispatchEvent(new Event("change")); // trigger formSelect population

        setTimeout(() => {
          formSelect.value = main.system_form_name;
          formSelect.dispatchEvent(new Event("change"));
        }, 300); // wait for formSelect to populate
      }

    } catch (error) {
      console.error("Fetch error:", error);
      alert("An error occurred while fetching data.");
    }


  }

  let tmpDetails =[];
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
      const sub1 = result.data || {};



      // Populate sub-table rows
      const tbody = document.querySelector("#dataTable tbody");
      tbody.innerHTML = ""; // Clear existing rows

      // Normalize sub1 to an array
      let sub1Array = [];

      if (Array.isArray(sub1)) {
        sub1Array = sub1;
      } else if (sub1 && typeof sub1 === 'object') {
        sub1Array = [sub1]; // wrap single object in an array
      }
      
      tmpDetails = sub1Array;
      // Loop through array to create table rows
      sub1Array.forEach(item => {
        const row = document.createElement("tr");
        row.innerHTML = `
                        <td><input type="text" name="data_point" value="${item.data_point || ""}" /></td>
                        <td><input type="text" name="reference_field" value="${item.ref_field || ""}" /></td>
                      `;
        tbody.appendChild(row);

      });



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
      } else if (sub1 && typeof sub1 === 'object') {
        sub1Array = [sub1];
      }

      // Create rows dynamically
      sub1Array.forEach(item => {
        const row = document.createElement("tr");
        row.innerHTML = `
          <td>
            <a href="${item.Link || "#"}" target="_blank">
              ${item.Link || "No Link"}
            </a>
          </td>
        `;
        tbody.appendChild(row);
      });

    } catch (error) {
      console.error("Fetch error:", error);
      alert("An error occurred while fetching uploaded files.");
    }
  }

  function generateUUIDv4() {
    return ([1e7] + -1e3 + -4e3 + -8e3 + -1e11).replace(/[018]/g, (c) =>
      (
        c ^
        (crypto.getRandomValues(new Uint8Array(1))[0] & (15 >> (c / 4)))
      ).toString(16)
    );
  }

  function loadDefaultsUserInfo(user) {
    if (user) {
      if (user.role === "User") {
        document.getElementById("user").value = user.name || "";
        document.getElementById("user_id").value = user.userId || "";
        ocument.getElementById("req_status").value = "For Head Approval";
      } else if (user.role === "Head") {
        if(mode ==="Add"){
          document.getElementById("user").value = user.name || "";
          document.getElementById("user_id").value = user.userId || "";
        }
        document.getElementById("department_head").value = user.name || "";
        document.getElementById("department_head_id").value = user.userId || "";
        document.getElementById("req_status").value = "For IT Approval";
      } else if (user.role === "IT Head") {
        if(mode ==="Add"){
          document.getElementById("user").value = user.name || "";
          document.getElementById("user_id").value = user.userId || "";

          document.getElementById("department_head").value = user.name || "";
          document.getElementById("department_head_id").value = user.userId || "";
        }
        document.getElementById("it_head").value = user.name || "";
        document.getElementById("it_head_id").value = user.userId || "";
        document.getElementById("req_status").value = "Approved";
      } else if (user.role === "Integrator") {
        document.getElementById("integrator").value = user.name || "";
        document.getElementById("integrator_id").value = user.userId || "";
      } else if (user.role === "Developer") {
        document.getElementById("developer").value = user.name || "";
        document.getElementById("developer_id").value = user.userId || "";
      } else if (user.role === "QA") {
        document.getElementById("qa").value = user.name || "";
        document.getElementById("qa").value = user.userId || "";
      }

    }
  }

  // Get default values (used when modal opens)
  window.getDefaults = async function (uuid, mode) {
    const user = JSON.parse(localStorage.getItem("user")); // Your user object
    const submitBtn = document.getElementById("submitBtn");
    submitBtn.disabled=true;
    if (mode === "Approve") {
      document.getElementById("modalTitle").textContent = "SERVICE REQUEST APPROVAL";
      document.getElementById("attachments").removeAttribute("required");
      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);
      loadDefaultsUserInfo(user);
    } else if (mode === "Add") {
      const today = new Date().toISOString().split("T")[0];
      document.getElementById("modalTitle").textContent = "SERVICE REQUEST ENTRY";
      document.getElementById("date_requested").value = today;
      document.getElementById("project").value = user.project || "CBMIS";
      document.getElementById("department").value = user.department || "";
      
      // 👇 Generate and assign UUID to hidden input
      const uuidField = document.getElementById("uuid");
      if (uuidField) {
        uuidField.value = generateUUIDv4();
      }
      loadDefaultsUserInfo(user);
    } if (mode === "Edit") {
      document.getElementById("modalTitle").textContent = "SERVICE REQUEST UPDATE";
      document.getElementById("attachments").removeAttribute("required");
      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);
    } if (mode === "Cancel") {
      document.getElementById("modalTitle").textContent = "SERVICE REQUEST CANCELLATION";
      document.getElementById("attachments").removeAttribute("required");
      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);
      document.getElementById("req_status").value = "Cancelled";
    }

    submitBtn.disabled=false;

  };

  // Save form function
  async function saveForm(event) {
    event.preventDefault();
    const form = event.target;
    const formData = new FormData(form);

    for (let pair of formData.entries()) {
      console.log(`${pair[0]}: ${pair[1]}`);
    }

    console.log(form);
    console.log(formData);

    const submitBtn = document.getElementById("submitBtn");
    const submitText = document.getElementById("submitText");

    // 🔒 Disable the button and show spinner
    if (submitBtn && submitText) {
      submitBtn.disabled = true;
      submitText.innerHTML = '<div class="spinner"></div>';
    }

    try {
      let proc ="";
      if (mode === "Approve" || mode === "Edit" || mode === "Cancel" ) {
        proc = "/update";
      } else{
        proc = "/create";
      }

      // Remove Details
      for (const item of tmpDetails) {
        await fetch(`${API_BASE_URL}/delete`, {
          method: "POST",
          body: formData,
        });
      }

      const response = await fetch(`${API_BASE_URL}${proc}`, {
        method: "POST",
        body: formData,
      });

      const result = await response.json();

      if (response.ok) {
        alert("Form submitted successfully!");
        form.reset();
        document.getElementById("formSelect").disabled = true;

        window.parent.loadMasterList();

        // Close the modal
        const modal = document.getElementById("createModal");
        if (modal) {
          modal.style.display = "none";
        }
      } else {
        alert(`Error: ${result.message || "Something went wrong"}`);
      }
    } catch (error) {
      console.error("Submission error:", error);
      alert("Failed to submit form. See console for details.");
    } finally {
      // 🔓 Re-enable the button and restore text
      if (submitBtn && submitText) {
        submitBtn.disabled = false;
        submitText.textContent = "Submit";
      }
    }
  }

  // Attach submit event

  const form = document.getElementById("entryForm");

  if (form) {
    form.addEventListener("submit", saveForm);
    console.log("✅ Form event attached");
  } else {
    console.warn("⚠️ entryForm not found in DOM");
  }

  // 🧠 Attach event when modal is shown (Bootstrap 5)
  const modal = document.getElementById("createModal");
  if (modal) {
    modal.addEventListener("show.bs.modal", () => {
      getDefaults();
    });
  }
})();

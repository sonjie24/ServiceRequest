(() => {
  const user = getUserSession();
  const data = getFunctinalitiesSession();
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

  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  const employeeData = getCylixSession();

  const integratorSelect = document.getElementById("integrator");
  const developerSelect = document.getElementById("developer");
  const qaSelect = document.getElementById("qa");

  // ✅ Populate all employees into each dropdown
  function populateSelect(select, data) {
    select.innerHTML = '<option value="" disabled selected>Select</option>';
    data.forEach((emp) => {
      const option = document.createElement("option");
      option.value = emp.EmployeeName; // Use name as value
      option.textContent = emp.EmployeeName;
      option.dataset.id = emp.ID; // Store ID
      select.appendChild(option);
    });
  }

  populateSelect(integratorSelect, employeeData);
  populateSelect(developerSelect, employeeData);
  populateSelect(qaSelect, employeeData);

  // ✅ Update hidden fields when user selects an option
  function bindHidden(select, hiddenInputId) {
    select.addEventListener("change", () => {
      const selected = select.options[select.selectedIndex];
      document.getElementById(hiddenInputId).value = selected.dataset.id || "";
    });
  }

  bindHidden(integratorSelect, "integrator_id");
  bindHidden(developerSelect, "developer_id");
  bindHidden(qaSelect, "qa_id");

  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  // Department data from session
  const departmentData = getDepartmentSession();

  // DOM Elements
  const departmentSelect = document.getElementById("department");
  const userSelect = document.getElementById("user");
  const headSelect = document.getElementById("department_head");
  const itHeadSelect = document.getElementById("it_head");

  // ✅ Populate departments
  Object.keys(departmentData).forEach((department) => {
    const option = document.createElement("option");
    option.value = department;
    option.textContent = department;
    departmentSelect.appendChild(option);
  });

  // ✅ Populate Users when department changes
  departmentSelect.addEventListener("change", () => {
    const selectedDepartment = departmentSelect.value;

    // Clear previous options
    userSelect.innerHTML =
      '<option value="" disabled selected>Select User</option>';
    headSelect.innerHTML =
      '<option value="" disabled selected>Select Head</option>';
    itHeadSelect.innerHTML =
      '<option value="" disabled selected>Select IT Head</option>';

    if (selectedDepartment && departmentData[selectedDepartment]) {
      userSelect.disabled = false;
      headSelect.disabled = false;
      itHeadSelect.disabled = false;

      const data = departmentData[selectedDepartment];

      // ✅ Populate Users
      data.User.forEach((u) => {
        const opt = document.createElement("option");
        opt.value = u.name;
        opt.textContent = u.name;
        opt.setAttribute("data-code", u.id);
        userSelect.appendChild(opt);
      });

      // ✅ Populate Heads
      data.Head.forEach((h) => {
        const opt = document.createElement("option");
        opt.value = h.name;
        opt.textContent = h.name;
        opt.setAttribute("data-code", h.id);
        headSelect.appendChild(opt);
      });

      // ✅ Populate IT Head (for this department)
      data["IT Head"].forEach((it) => {
        const opt = document.createElement("option");
        opt.value = it.name;
        opt.textContent = it.name;
        opt.setAttribute("data-code", it.id);
        itHeadSelect.appendChild(opt);
      });
    } else {
      userSelect.disabled = true;
      headSelect.disabled = true;
      itHeadSelect.disabled = true;
    }
  });

  // When a user is selected, show its code in the input
  userSelect.addEventListener("change", () => {
    const selectedOption = userSelect.options[userSelect.selectedIndex];
    const code = selectedOption.getAttribute("data-code");
    document.getElementById("user_id").value = code || "";
  });

  // When a head is selected, show its code in the input
  headSelect.addEventListener("change", () => {
    const selectedOption = headSelect.options[headSelect.selectedIndex];
    const code = selectedOption.getAttribute("data-code");
    document.getElementById("department_head_id").value = code || "";
  });

  // When a head is selected, show its code in the input
  itHeadSelect.addEventListener("change", () => {
    const selectedOption = itHeadSelect.options[headSelect.selectedIndex];
    const code = selectedOption.getAttribute("data-code");
    document.getElementById("it_head_id").value = code || "";
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

  function toggleFormReadOnly(formId, mode = "View", exceptions = []) {
    const form = document.getElementById(formId);
    if (!form) return;

    const isAdd = mode.toLowerCase() === "add";
    const isException = (el) =>
      exceptions.includes(el.id) || exceptions.includes(el.name);

    // ✅ Handle inputs
    form.querySelectorAll("input").forEach((el) => {
      if (["hidden", "file"].includes(el.type)) return;

      if (isAdd || isException(el)) {
        el.readOnly = false;
        el.style.pointerEvents = "auto";
        el.style.backgroundColor = "";
        el.removeAttribute("readonly");
      } else {
        if (["checkbox", "radio"].includes(el.type)) {
          el.style.pointerEvents = "none"; // Instead of disabling
        } else {
          el.readOnly = true;
          el.style.backgroundColor = "#f9f9f9";
        }
      }
    });

    // ✅ Handle textareas
    form.querySelectorAll("textarea").forEach((el) => {
      if (isAdd || isException(el)) {
        el.readOnly = false;
        el.style.backgroundColor = "";
        el.removeAttribute("readonly");
      } else {
        el.readOnly = true;
        el.style.backgroundColor = "#f9f9f9";
      }
    });

    // ✅ Handle selects
    form.querySelectorAll("select").forEach((el) => {
      if (isAdd || isException(el)) {
        el.style.pointerEvents = "auto";
        el.style.backgroundColor = "";
      } else {
        el.style.pointerEvents = "none";
        el.style.backgroundColor = "#f3f3f3";
      }
    });
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
          <td><input type="text" name="data_point" value="${item.data_point || ""}" /></td>
          <td><input type="text" name="reference_field" value="${item.ref_field || ""}" /></td>
        `;
        tbody.appendChild(row);
      });

<<<<<<< HEAD
      // ✅ Optionally add a blank row for new entry
      const blankRow = document.createElement("tr");
      blankRow.innerHTML = `
        <td><input type="text" name="data_point" value="" /></td>
        <td><input type="text" name="reference_field" value="" /></td>
      `;
      tbody.appendChild(blankRow);
      
=======

<<<<<<< HEAD
>>>>>>> e9c156a23cb64a440f7aaf9859fc46e3a3e5f5ab
=======

>>>>>>> parent of 430a071 (asd)
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

  // Remove Files (global for onclick)
  window.removeFile = async function (GDriveID, button) {
    await fetch(`${API_BASE_URL}/delete-file`, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ GDriveID }),
    });
    const row = button.closest("tr");
    row.remove();
    alert("Deleted successfully!");
  };

  function generateUUIDv4() {
    return ([1e7] + -1e3 + -4e3 + -8e3 + -1e11).replace(/[018]/g, (c) =>
      (
        c ^
        (crypto.getRandomValues(new Uint8Array(1))[0] & (15 >> (c / 4)))
      ).toString(16)
    );
  }

  function makeSelectReadOnly(select) {
    // Prevent mouse clicks and keyboard changes
    select.addEventListener("mousedown", (e) => e.preventDefault());
    select.addEventListener("keydown", (e) => e.preventDefault());

    // Optional: style to indicate it's readonly
    select.style.backgroundColor = "#f3f3f3";
    select.style.pointerEvents = "none"; // disables mouse, but keeps value
  }

  function loadDefaultsUserInfo(user) {
    if (user) {
      // ✅ Step 1: Select department and trigger user/head population
      if (user.department) {
        departmentSelect.value = user.department;

        // ✅ Step 2: Trigger population and wait for it to finish
        departmentSelect.dispatchEvent(new Event("change"));
        setTimeout(() => {
          makeSelectReadOnly(document.getElementById("integrator"));
          makeSelectReadOnly(document.getElementById("developer"));
          makeSelectReadOnly(document.getElementById("qa"));

          if (user.role === "User") {
            userSelect.value = user.name || "";
            userSelect.dispatchEvent(new Event("change"));
            document.getElementById("req_status").value = "For Head Approval";
          } else if (user.role === "Head") {
            if (mode === "Add") {
              userSelect.value = user.name;
              userSelect.dispatchEvent(new Event("change"));
            }
            headSelect.value = user.name;
            headSelect.dispatchEvent(new Event("change"));
            document.getElementById("req_status").value = "For IT Approval";
          } else if (user.role === "IT Head") {
            if (mode === "Add") {
              userSelect.value = user.name;
              userSelect.dispatchEvent(new Event("change"));

              headSelect.value = user.name;
              headSelect.dispatchEvent(new Event("change"));
            }
            itHeadSelect.value = user.name;
            itHeadSelect.dispatchEvent(new Event("change"));
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
        }, 300); // wait for formSelect to populate
      }
    }
  }

  // Get default values (used when modal opens)
  window.getDefaults = async function (uuid, mode) {
    const submitBtn = document.getElementById("submitBtn");

    submitBtn.disabled = true;
    if (mode === "Add") {
      const today = new Date().toISOString().split("T")[0];
      document.getElementById("modalTitle").textContent =
        "SERVICE REQUEST ENTRY";
      document.getElementById("submitText").textContent = "SAVE";
      document.getElementById("date_requested").value = today;
      document.getElementById("project").value = user.project || "CBMIS";
      document.getElementById("department").value = user.department || "";

      // 👇 Generate and assign UUID to hidden input
      const uuidField = document.getElementById("uuid");
      if (uuidField) {
        uuidField.value = generateUUIDv4();
      }

      // Show table only if userRole is allowed
      const statusTable = document.getElementById("status_update");
      const allowedRoles = ["Admin"];
      if (!allowedRoles.includes(user.role)) {
        statusTable.style.display = "none";
      } else {
        statusTable.style.display = "table"; // or "block"
      }

      loadDefaultsUserInfo(user);
    } else if (mode === "Edit") {
      document.getElementById("modalTitle").textContent =
        "SERVICE REQUEST UPDATE";
      document.getElementById("submitText").textContent = "UPDATE";
      document.getElementById("attachments").removeAttribute("required");

      // Show table only if userRole is allowed
      const statusTable = document.getElementById("status_update");
      const allowedRoles = ["Admin"];
      if (!allowedRoles.includes(user.role)) {
        statusTable.style.display = "none";
      } else {
        statusTable.style.display = "table"; // or "block"
      }

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);
    } else if (mode === "Cancel") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);
      document.getElementById("modalTitle").textContent =
        "SERVICE REQUEST CANCELLATION";
      document.getElementById("submitText").textContent = "CANCEL";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("req_status").value = "Cancelled";
    } else if (mode === "Approve Head") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);
      document.getElementById("modalTitle").textContent =
        "SERVICE REQUEST APPROVAL";
      document.getElementById("submitText").textContent = "APPROVE";
      document.getElementById("attachments").removeAttribute("required");
      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      headSelect.value = user.name;
      headSelect.dispatchEvent(new Event("change"));
      document.getElementById("req_status").value = "For IT Approval";
    } else if (mode === "Approve IT") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);
      document.getElementById("modalTitle").textContent =
        "SERVICE REQUEST APPROVAL";
      document.getElementById("submitText").textContent = "APPROVE";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      itHeadSelect.value = user.name;
      itHeadSelect.dispatchEvent(new Event("change"));
      document.getElementById("req_status").value = "Approved";
    } else if (mode === "Accept") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
        "developer",
      ]);
      document.getElementById("modalTitle").textContent =
        "ACCEPT SERVICE REQUEST";
      document.getElementById("submitText").textContent = "ACCEPT";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("cylix_status").value = "Accepted";
      document.getElementById("dev_status").value = "For Development";
      document.getElementById("integrator").value = user.name || "";
      document.getElementById("integrator_id").value = user.userId || "";
    } else if (mode === "Accept Admin") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
        "integrator",
        "developer",
        "qa",
      ]);
      document.getElementById("modalTitle").textContent =
        "ACCEPT SERVICE REQUEST";
      document.getElementById("submitText").textContent = "ACCEPT";
      document.getElementById("attachments").removeAttribute("required");
      document
        .getElementById("integrator")
        .setAttribute("required", "required");
      document.getElementById("developer").setAttribute("required", "required");
      document.getElementById("qa").setAttribute("required", "required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("cylix_status").value = "Accepted";
      document.getElementById("dev_status").value = "For Development";
      document.getElementById("integrator").value = "";
      document.getElementById("integrator_id").value = "";
    } else if (mode === "Accept Development") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);
      document.getElementById("modalTitle").textContent = "FOR DEVELOPMENT";
      document.getElementById("submitText").textContent = "ACCEPT";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("dev_status").value = "Ongoing";
      document.getElementById("developer").value = user.name || "";
      document.getElementById("developer_id").value = user.userId || "";
    } else if (mode === "Done Development") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);
      document.getElementById("modalTitle").textContent = "DONE DEVELOPMENT";
      document.getElementById("submitText").textContent = "DONE";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("dev_status").value = "For QA";
    } else if (mode === "Accept QA") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);
      document.getElementById("modalTitle").textContent = "FOR TESTING";
      document.getElementById("submitText").textContent = "ACCEPT";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("dev_status").value = "QA";
      document.getElementById("qa").value = user.name || "";
      document.getElementById("qa_id").value = user.userId || "";
    } else if (mode === "Done QA") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);
      document.getElementById("modalTitle").textContent = "DONE TESTING";
      document.getElementById("submitText").textContent = "DONE";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("dev_status").value = "For Deployment";
    } else if (mode === "Deploy") {
      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
        "patch_date",
      ]);
      document.getElementById("modalTitle").textContent = "DEPLOY CONCERN";
      document.getElementById("submitText").textContent = "DEPLOY";
      document.getElementById("attachments").removeAttribute("required");
      document
        .getElementById("patch_date")
        .setAttribute("required", "required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("dev_status").value = "Deployed";
    } else if (mode === "Done Fixed") {
      toggleFormReadOnly("entryForm", "View", ["memo"]);
      document.getElementById("modalTitle").textContent = "FIXED CONCERN";
      document.getElementById("submitText").textContent = "FIXED";
      document.getElementById("attachments").removeAttribute("required");

      await getData(uuid);
      await getDataDetails(uuid);
      await getDataFiles(uuid);

      document.getElementById("cylix_status").value = "Completed";
    }

    submitBtn.disabled = false;
  };

  // Save form function
  async function saveForm(event) {
    event.preventDefault();
    const form = event.target;
    const formData = new FormData(form);

    const formObj = {};
    formData.forEach((value, key) => (formObj[key] = value));

    const submitBtn = document.getElementById("submitBtn");
    const submitText = document.getElementById("submitText");

    // 🔒 Disable the button and show spinner
    if (submitBtn && submitText) {
      submitBtn.disabled = true;
      submitText.innerHTML = '<div class="spinner"></div>';
    }

    try {
      let proc = "";
      if (mode === "Add") {
        proc = "/create";
      } else {
        proc = "/update";
      }
        

      // Remove Details
      const detailData = getDetailDataSession();
      detailData.forEach((item) => {
          fetch(`${API_BASE_URL}/delete`, {
          method: "POST",
          body: formData,
        });
      });
   

      // Save/Update Endpoint
      const response = await fetch(`${API_BASE_URL}${proc}`, {
        method: "POST",
        body: formData,
      });

      const result = await response.json();

      if (response.ok) {
        alert("Form submitted successfully!");
        form.reset();
        document.getElementById("formSelect").disabled = true;

        // Close the modal
        const modal = document.getElementById("createModal");
        if (modal) {
          modal.style.display = "none";
        }
        window.parent.loadMasterList();
        // sessionStorage.removeItem("detailData");
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

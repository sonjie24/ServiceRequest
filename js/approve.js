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
      service_request_no: main.service_request_no
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

      console.log(result);

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
      const sub1 = result.data[0] || {};

      console.log(result);

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


  // Get default values (used when modal opens)
  window.getDefaults = async function (uuid) {
    await getData(uuid);
    const user = JSON.parse(localStorage.getItem("user")); // Your user object
    console.log(user.role);
    if (user) {
      if (user.role === "User") {
        document.getElementById("user").value = user.name || "";
      } else if (user.role === "Head") {
        document.getElementById("department_head").value = user.name || "";
      } else if (user.role === "IT Head") {
        document.getElementById("it_head").value = user.name || "";
      } else if (user.role === "Integrator") {
        document.getElementById("integrator").value = user.name || "";
      } else if (user.role === "Developer") {
        document.getElementById("developer").value = user.name || "";
      } else if (user.role === "QA") {
        document.getElementById("qa").value = user.name || "";
      }

      if (user.role === "User") {
        document.getElementById("user_id").value = user.userId || "";
      } else if (user.role === "Head") {
        document.getElementById("department_head_id").value = user.userId || "";
      } else if (user.role === "IT Head") {
        document.getElementById("it_head_id").value = user.userId || "";
      } else if (user.role === "Integrator") {
        document.getElementById("integrator_id").value = user.userId || "";
      } else if (user.role === "Developer") {
        document.getElementById("developer_id").value = user.userId || "";
      } else if (user.role === "QA_id") {
        document.getElementById("qa").value = user.userId || "";
      }

    }


  };

  // Save form function
  async function saveForm(event) {
    event.preventDefault();
    const form = event.target;
    const formData = new FormData(form);

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
      const response = await fetch(`${API_BASE_URL}/create`, {
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

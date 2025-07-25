(() => {
  const data = JSON.parse(localStorage.getItem("functionalities"));
  const user = JSON.parse(localStorage.getItem("user")); // Your user object

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

  function generateUUIDv4() {
    return ([1e7] + -1e3 + -4e3 + -8e3 + -1e11).replace(/[018]/g, (c) =>
      (
        c ^
        (crypto.getRandomValues(new Uint8Array(1))[0] & (15 >> (c / 4)))
      ).toString(16)
    );
  }

  // Get default values (used when modal opens)
  window.getDefaults = function () {
    const today = new Date().toISOString().split("T")[0];
    
    if (user) {
      document.getElementById("project").value = user.project || "CBMIS";
      
      document.getElementById("department").value = user.department || "";
        console.log(user.role);
      if (user.role === "User") {
         document.getElementById("user").value = user.name || "";
      } else if(user.role === "Head") {
        document.getElementById("department_head").value = user.name || "";
      } else if(user.role === "IT Head") {
        document.getElementById("it_head").value = user.name || "";
      } else if(user.role === "Integrator") {
        document.getElementById("integrator").value = user.name || "";
      } else if(user.role === "Developer") {
        document.getElementById("developer").value = user.name || "";
      } else if(user.role === "QA") {
        document.getElementById("qa").value = user.name || "";
      }

       if (user.role === "User") {
         document.getElementById("user_id").value = user.userId || "";
      } else if(user.role === "Head") {
        document.getElementById("department_head_id").value = user.userId || "";
      } else if(user.role === "IT Head") {
        document.getElementById("it_head_id").value = user.userId || "";
      } else if(user.role === "Integrator") {
        document.getElementById("integrator_id").value = user.userId || "";
      } else if(user.role === "Developer") {
        document.getElementById("developer_id").value = user.userId || "";
      } else if(user.role === "QA_id") {
        document.getElementById("qa").value = user.userId || "";
      }
    
    }

    

    document.getElementById("date_requested").value = today;
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

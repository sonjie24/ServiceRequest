(() => {
  const data = JSON.parse(localStorage.getItem("functionalities"));
  const user = JSON.parse(localStorage.getItem("user")); // Your user object

  const systemSelect = document.getElementById("systemSelect");
  const formSelect = document.getElementById("formSelect");
  const formNoInput = document.getElementById("form_no");

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
    formSelect.innerHTML = '<option value="" disabled selected>Select Form</option>';
    formSelect.disabled = true;
    formNoInput.value = "";

    if (selectedSystem && systems[selectedSystem]) {
      formSelect.disabled = false;

      systems[selectedSystem].forEach((form) => {
        const option = document.createElement("option");
        option.value = form.code;
        option.textContent = form.name;
        formSelect.appendChild(option);
      });
    }
  });

  // When a form is selected, show its code in the input
  formSelect.addEventListener("change", () => {
    const selectedOption = formSelect.options[formSelect.selectedIndex];
    formNoInput.value = selectedOption.value || "";
  });

  // Add row function (global for onclick)
  window.addRow = function () {
    const tableBody = document.querySelector("#dataTable tbody");
    const newRow = document.createElement("tr");
    newRow.innerHTML = `
      <td><input type="text" name="data_point[]" /></td>
      <td><input type="text" name="reference_field[]" /></td>
    `;
    tableBody.appendChild(newRow);
  };

  // Get default values (used when modal opens)
  window.getDefaults = function () {
    const today = new Date().toISOString().split("T")[0];
    if (user) {
      document.getElementById("project").value = user.project || "CBMIS";
      document.getElementById("integrator").value = user.name || "";
      document.getElementById("department").value = user.department || "";
    }
    document.getElementById("date_requested").value = today;
  };

  // Save form function
  async function saveForm(event) {
    event.preventDefault();
    const form = event.target;
    const formData = new FormData(form);

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
        document.getElementById("form_no").disabled = true;

        // ✅ Hide the modal
        const modal = document.getElementById("modal");
        if (modal) {
          modal.style.display = "none";
        }
      } else {
        alert(`Error: ${result.message || "Something went wrong"}`);
      }
    } catch (error) {
      console.error("Submission error:", error);
      alert("Failed to submit form. See console for details.");
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

  // 🔁 Fallback: If not using Bootstrap modal, use MutationObserver to detect display change
  const observer = new MutationObserver(() => {
    if (modal.style.display !== "none") {
      getDefaults();
    }
  });

  if (modal) {
    observer.observe(modal, { attributes: true, attributeFilter: ["style"] });
  }
})();

(() => {

  //const data = [{"Treasury":{"Business Tax":[{"name":"Formn1","code":"FRM000001"},{"name":"Formn2","code":"FRM000002"},{"name":"Formn3","code":"FRM000003"},{"name":"Formn4","code":"FRM000004"}],"Real Property Tax":[{"name":"Formn5","code":"FRM000005"},{"name":"Formn6","code":"FRM000006"},{"name":"Formn7","code":"FRM000007"},{"name":"Formn8","code":"FRM000008"},{"name":"Formn9","code":"FRM000009"},{"name":"Formn10","code":"FRM000010"}]}}];
  const data = JSON.parse(sessionStorage.getItem("functionalities"));

  
  const systemSelect = document.getElementById("systemSelect");
  const moduleSelect = document.getElementById("moduleSelect");
  const formSelect = document.getElementById("formSelect");
  const formNoInput = document.getElementById("formNo");

  const systems = data.Functionalities;
  
  Object.keys(systems).forEach(system => {
    const option = document.createElement("option");
    option.value = system;
    option.textContent = system;
    systemSelect.appendChild(option);
  });

  systemSelect.addEventListener("change", () => {
    const selectedSystem = systemSelect.value;
    moduleSelect.innerHTML = '<option value="" disabled selected>Select Module</option>';
    formSelect.innerHTML = '<option value="" disabled selected>Select Form</option>';
    formSelect.disabled = true;

    if (selectedSystem && systems[selectedSystem]) {
      moduleSelect.disabled = false;
      Object.keys(systems[selectedSystem]).forEach(module => {
        const option = document.createElement("option");
        option.value = module;
        option.textContent = module;
        moduleSelect.appendChild(option);
        formNoInput.value = "";
      });
    } else {
      moduleSelect.disabled = true;
    }
  });

  moduleSelect.addEventListener("change", () => {
    const selectedSystem = systemSelect.value;
    const selectedModule = moduleSelect.value;

    formSelect.innerHTML = '<option value="" disabled selected>Select Form</option>';

    if (selectedSystem && selectedModule && systems[selectedSystem][selectedModule]) {
      formSelect.disabled = false;
      systems[selectedSystem][selectedModule].forEach(form => {
        const option = document.createElement("option");
        option.value = form.code;
        option.textContent = `${form.name}`;
        formSelect.appendChild(option);
        formNoInput.value = "";
      });
    } else {
      formSelect.disabled = true;
    }
  });

  formSelect.addEventListener("change", () => {
    const selectedOption = formSelect.options[formSelect.selectedIndex];
    formNoInput.value = selectedOption.value || "";
  });

  window.addRow = function () {
    const table = document.getElementById("dataTable").getElementsByTagName('tbody')[0];
    const newRow = document.createElement("tr");

    newRow.innerHTML = `
      <td><input type="text" name="data_point[]" /></td>
      <td><input type="text" name="reference_field[]" /></td>
    `;

    table.appendChild(newRow);
  };
})();

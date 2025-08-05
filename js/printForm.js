(() => {
  const user = getUserSession();

  // print function (global for onclick)
  window.printModal = function () {
    const modalForm = document.querySelector("#createModal .form-container");
    const clone = modalForm.cloneNode(true);

    // Replace form fields with their current values
    clone.querySelectorAll("input, select, textarea").forEach((el) => {
      if (el.classList.contains("employee-id")) return;

      let text = "";

      if (el.type === "checkbox") {
        text = el.checked ? "☑" : "☐";
      } else if (el.tagName === "SELECT") {
        text = el.options[el.selectedIndex]?.text || "";
      } else {
        text = el.value.trim();

        // Only strip ID if input has class 'strip-id'
        if (el.classList.contains("strip-id")) {
          const parts = text.split(" ");
          const last = parts[parts.length - 1];
          if (!isNaN(last)) {
            text = parts.slice(0, -1).join(" ");
          }
        }
      }

      const span = document.createElement("span");
      span.textContent = text;
      el.replaceWith(span);
    });

    const printWindow = window.open("", "", "width=1000,height=700");

    printWindow.document.write(`
    <html>
      <head>
        <title>Print Form</title>
        <style>
          @page {
            size: 8.5in 13in; /* Long bond paper */
            margin: .2in;
          }

          body {
            font-family: Arial, sans-serif;
            padding: 20px;
          }

          table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
          }

          th, td {
            border: 1px solid #ccc;
            padding: 8px;
          }

          .section-title {
            font-weight: bold;
            background: #f0f0f0;
          }
          @media print {
        button, 
        .employee-id {
          display: none !important;
        }
        .no-print {
          display: none !important;
        }
        .employee-id {
          display: none;
        }
        #memo-table {
          display: none;
        }

        #memo-table.show-in-print {
        display: table;
        }

          h2 {
            text-align: center;
          }
        </style>
      </head>
      <body>
        ${clone.innerHTML}
        <script>
          window.onload = function() {
            window.print();
            window.onafterprint = function() {
              window.close();
            };
          };
        </script>
      </body>
    </html>
  `);

    printWindow.document.close();
  };

     window.addEventListener('beforeprint', function () {
    const memo = document.getElementById('memo');
    const table = document.getElementById('memo-table');
    if (memo.value.trim() !== '') {
      table.classList.add('show-in-print');
    } else {
      table.classList.remove('show-in-print');
    }
  });

  function mapDataToForm(main) {
    const fieldMap = {
      uuid: main.uuid,
      project: main.project || "CBMIS",
      department: main.department,
      module: main.module,
      system_form_name: main.system_form_name,
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

      mapDataToForm(main); // <-- Populate main form field
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

      // Get table body element
      const tbody = document.getElementById("details_data");

      // Clear existing rows
      tbody.innerHTML = "";

      // Loop through array to create table rows
      detailData.forEach((item) => {
        const row = document.createElement("tr"); // ✅ FIX: create <tr> not item
        row.innerHTML = `
          <td><input type="text" name="data_point" value="1. ${
            item.data_point || ""
          }" /></td>
          <td><input type="text" name="reference_field" value="${
            item.ref_field || ""
          }" /></td>
        `;
        tbody.appendChild(row);
      });

      // Calculate how many blank rows to add
      const totalRows = detailData.length;
      const rowsToAdd = Math.max(0, 5 - totalRows);

      // ✅ Optionally add a blank row for new entry
      for (let i = 1; i <= rowsToAdd; i++) {
        const blankRow = document.createElement("tr");
        blankRow.innerHTML = `
          <td><input type="text" name="data_point" value="${i+1}. " /></td>
          <td><input type="text" name="reference_field" value="" /></td>
        `;
        tbody.appendChild(blankRow);
      }
          
 
    } catch (error) {
      console.error("Fetch error:", error);
      alert("An error occurred while fetching data.");
    }
  }

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
  }

  // Get default values (used when modal opens)
  window.getDefaults = async function (uuid, mode) {
    if (mode === "View") {
      document.getElementById("modalTitle").textContent = "SERVICE REQUEST";
      document.getElementById("submitText").textContent = "Print";

      toggleFormReadOnly("entryForm", "View", [
        "attachments",
        "memo",
        "dataTable",
      ]);

      await getData(uuid);
      await getDataDetails(uuid);
    }
  };
})();

function checkMark(value) {
  return value === "Yes" ? "✔️" : "";
}

window.addEventListener("DOMContentLoaded", async () => {
  const urlParams = new URLSearchParams(window.location.search);
  const uuid = urlParams.get("id");

  console.log("UUID from URL:", uuid);

  if (!uuid) {
    alert("No UUID provided");
    return;
  }

  try {
    const response = await fetch('https://your-api-url.com/get-one', {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ uuid })
    });

    const result = await response.json();
    console.log("API Result:", result);

    if (!result || !result.data) {
      alert("No data found for UUID: " + uuid);
      return;
    }

    const record = result.data;

    const safeSet = (id, value) => {
      const el = document.getElementById(id);
      if (el) el.innerHTML = `<strong>${value ?? ""}</strong>`;
    };

    const safeText = (id, value) => {
      const el = document.getElementById(id);
      if (el) el.textContent = value ?? "";
    };

    // Set values
    safeSet("date_requested", record.date_requested);
    safeSet("service_request_no", record.service_request_no);
    safeSet("department", record.department);
    safeSet("module", record.module);
    safeSet("system_form_no", record.system_form_no);
    safeSet("system_form_name", record.system_form_name);

    safeText("concern_type_new", checkMark(record.concern_type_new));
    safeText("concern_type_rev", checkMark(record.concern_type_rev));
    safeText("concern_type_del", checkMark(record.concern_type_del));
    safeText("concern_type_cos", checkMark(record.concern_type_cos));
    safeText("concern_type_data", checkMark(record.concern_type_data));

    safeText("priority_set", checkMark(record.priority_set));
    safeText("priority_immediate", checkMark(record.priority_immediate));
    safeText("priority_add", checkMark(record.priority_add));

    safeText("user", record.user);
    safeText("department_head", record.department_head);
    safeText("it_head", record.it_head);
    safeText("integrator", record.integrator);
    safeText("developer", record.developer);
    safeText("qa", record.qa);

    safeText("print_option_as_req", checkMark(record.print_option_as_req));
    safeText("print_option_sys_print", checkMark(record.print_option_sys_print));
    safeText("print_option_modified", checkMark(record.print_option_modified));

    safeText("print_out_date", record.print_out_date);
    safeText("system_print_date", record.system_print_date);
    safeText("patch_date", record.patch_date);

  } catch (error) {
    console.error("Failed to load print data:", error);
    alert("Error fetching record for UUID: " + uuid);
  }
});

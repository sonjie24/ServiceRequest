 

async function getFunctionalities(projectName) {
  try {
 
    const res = await fetch(`${API_BASE_URL}/get-functionalities`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ projectName }),
    });

    if (!res.ok) {
      throw new Error(`HTTP error! Status: ${res.status}`);
    }

    const data = await res.json();

    if (data.data && data.data.length > 0) {
      const functionalities = data.data[0];
      saveFunctionalitiesSession(functionalities);
    } else {
      alert(data.message || "No functionalities returned.");
    }
  } catch (error) {
    console.error("Fetch error:", error);
    console.log("An error occurred while fetching functionalities.");
  }
}


async function getDepartments(projectName) {
  try {

    const res = await fetch(`${API_BASE_URL}/get-department`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ projectName }),
    });

    if (!res.ok) {
      throw new Error(`HTTP error! Status: ${res.status}`);
    }

    const data = await res.json();

    if (data.data && data.data.length > 0) {
      const department = data.data[0];
      saveDepartmentSession(department);
    } else {
      alert(data.message || "No department returned.");
    }
  } catch (error) {
    console.error("Fetch error:", error);
    console.log("An error occurred while fetching department.");
  }
}

 
    async function loginUser(event) {
    event.preventDefault();

    const spinner = document.getElementById("spinner");
    const loginBtn = document.getElementById("loginBtn");

    // Show spinner, hide button
    spinner.style.display = "block";
    loginBtn.style.display = "none";

    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;
 

    try {
        const res = await fetch(`${API_BASE_URL}/login`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ username, password, project }),
        });

        const data = await res.json();

        if (data.data && data.data.length > 0) {
            const user = data.data[0];

            const userData = {
                userId: user.ID,
                name: user.EmployeeName,
                email: user.email_address,
                department: user.Department,
                project: user.Project,
                role: user.Role,
            };

            await getFunctionalities();
            await getDepartments();
            await getCylix();
            saveUserSession(userData);
            window.location.href = `${BASE_PATH}pages/master.html`;
        } else {
            alert(data.message || "Login failed.");
        }
    } catch (error) {
        alert("Login error: " + error.message);
    } finally {
        // Hide spinner, show button again if still on page
        spinner.style.display = "none";
        loginBtn.style.display = "block";
    }
}

async function getFunctionalities() {
    try {
        const res = await fetch(`${API_BASE_URL}/get-functionalities`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            // If you need to send body data, add it here:
            // body: JSON.stringify({ key: "value" }),
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
        alert("An error occurred while fetching functionalities.");
    }
}

async function getDepartments() {
    try {
        const res = await fetch(`${API_BASE_URL}/get-department`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            // If you need to send body data, add it here:
            // body: JSON.stringify({ key: "value" }),
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
        alert("An error occurred while fetching department.");
    }
}

async function getCylix() {
    try {
        const res = await fetch(`${API_BASE_URL}/get-cylix`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            // If you need to send body data, add it here:
            // body: JSON.stringify({ key: "value" }),
        });

        if (!res.ok) {
            throw new Error(`HTTP error! Status: ${res.status}`);
        }

        const data = await res.json();

        if (data.data && data.data.length > 0) {

            const cylix = data.data;
            saveCylixSession(cylix);
        } else {
            alert(data.message || "No department returned.");
        }
    } catch (error) {
        console.error("Fetch error:", error);
        alert("An error occurred while fetching department.");
    }
}
 

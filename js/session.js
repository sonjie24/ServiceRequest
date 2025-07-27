// session.js

// Save user data to session
function saveUserSession(userData) {
  sessionStorage.setItem("user", JSON.stringify(userData));
}

// Save functionalities to session
function saveFunctionalitiesSession(userFunctionalities) {
  sessionStorage.setItem("functionalities", JSON.stringify(userFunctionalities));
}

// Save functionalities to session
function saveDepartmentSession(department) {
  sessionStorage.setItem("department", JSON.stringify(department));
}

// Save functionalities to session
function saveCylixSession(cylix) {
  sessionStorage.setItem("cylix", JSON.stringify(cylix));
}

// Get user data from session
function getUserSession() {
  const user = sessionStorage.getItem("user");
  return user ? JSON.parse(user) : null;
}

function getFunctinalitiesSession() {
  const functionalities = sessionStorage.getItem("functionalities");
  return user ? JSON.parse(functionalities) : null;
}

function getCylixSession() {
  const cylix = sessionStorage.getItem("cylix");
  return user ? JSON.parse(cylix) : null;
}

function getDepartmentSession() {
  const dept = sessionStorage.getItem("department");
  return user ? JSON.parse(dept) : null;
}




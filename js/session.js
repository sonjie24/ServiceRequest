// session.js

// Save user data to session
function saveUserSession(userData) {
  localStorage.setItem("user", JSON.stringify(userData));
}

// Save functionalities to session
function saveFunctionalitiesSession(userFunctionalities) {
  localStorage.setItem("functionalities", JSON.stringify(userFunctionalities));
}

// Save functionalities to session
function saveDepartmentSession(department) {
  localStorage.setItem("department", JSON.stringify(department));
}

// Get user data from session
function getUserSession() {
  const user = localStorage.getItem("user");
  return user ? JSON.parse(user) : null;
}

// Clear user session (for logout)
function clearUserSession() {
  localStorage.removeItem("user");
}

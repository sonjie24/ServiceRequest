// session.js

// Save user data to session
function saveUserSession(userData) {
  sessionStorage.setItem("user", JSON.stringify(userData));
}

// Get user data from session
function getUserSession() {
  const user = sessionStorage.getItem("user");
  return user ? JSON.parse(user) : null;
}

// Clear user session (for logout)
function clearUserSession() {
  sessionStorage.removeItem("user");
}

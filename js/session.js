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


// Save functionalities to session
function saveDetailDataSession(detailData) {
  sessionStorage.setItem("detailData", JSON.stringify(detailData));
}



// Save functionalities to session
function savelogInProject(logInProject) {
  sessionStorage.setItem("logInProject", JSON.stringify(logInProject));
}



// Get user data from session
function getUserSession() {
  const user = sessionStorage.getItem("user");
  return user ? JSON.parse(user) : null;
}

function getFunctinalitiesSession() {
  const functionalities = sessionStorage.getItem("functionalities");
  return functionalities ? JSON.parse(functionalities) : null;
}


function getDetailDataSession() {
  const detailData = sessionStorage.getItem("detailData");
  return detailData ? JSON.parse(detailData) : null;
}

function getCylixSession() {
  const cylix = sessionStorage.getItem("cylix");
  return cylix ? JSON.parse(cylix) : null;
}

function getDepartmentSession() {
  const dept = sessionStorage.getItem("department");
  return dept ? JSON.parse(dept) : null;
}


// Get user data from session
function getlogInProject() {
  const logInProject = sessionStorage.getItem("logInProject");
  return logInProject ? JSON.parse(logInProject) : null;
}



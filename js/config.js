<<<<<<< HEAD


const hostname = window.location.hostname;
const isLocal = hostname === "20.20.40.221";

// Use a local or remote API base URL depending on environment
const API_BASE_URL = isLocal
  ? "http://20.20.40.221:5679/webhook"               // Local dev server
  : "https://500e18becc4f.ngrok-free.app/webhook"; // Production API


 
// Dynamically set the <base> tag for GitHub Pages vs local
// config.js
(function () {
    const repoName = "ServiceRequest"; // Update if needed
    const isGithub = window.location.hostname.includes("github.io");
    const basePath = isGithub ? `/${repoName}/` : '/';
  
    const base = document.createElement("base");
    base.href = basePath;
    document.head.prepend(base);
  
    // Expose basePath to other scripts
    window.BASE_PATH = basePath;
  })();
  
=======
(function () {
  const repoName = "ServiceRequest"; // Update if needed
  const hostname = window.location.hostname;


  let basePath = "";
  if (hostname.includes("github.io") || hostname.includes("20.20.40.221")) {
    // GitHub Pages can't make backend calls directly unless it's public API or proxied
    basePath = `/${repoName}/`;
  } else {
    basePath = '/';
  }

  

  // Set base path for GitHub Pages or local
  const isGithub = hostname.includes("github.io");
  const base = document.createElement("base");
  base.href = basePath;
  document.head.prepend(base);

  // Expose basePath to other scripts
  window.BASE_PATH = basePath;

  // Set API base URL based on hostname
  let apiBaseUrl = "";

  if (isGithub) {
    // GitHub Pages can't make backend calls directly unless it's public API or proxied
    apiBaseUrl = "https://500e18becc4f.ngrok-free.app/webhook"; // Replace with real prod endpoint
  } else {
    apiBaseUrl = "http://20.20.40.221:5678/webhook"; // Fallback
  }

  // Expose API_BASE_URL to other scripts
  window.API_BASE_URL = apiBaseUrl;
})();
>>>>>>> b75e8b5b1a4e44ec30f88f79ea2a8d0822cf0906

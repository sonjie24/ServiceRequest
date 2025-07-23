//const API_BASE_URL = "http://localhost:5678/webhook";
const API_BASE_URL = "https://500e18becc4f.ngrok-free.app/webhook";

 
// Dynamically set the <base> tag for GitHub Pages vs local
// config.js
(function () {
    const repoName = "ServiceRequest"; // Update if needed
    const isGithub = window.location.hostname.includes("github.io");
  
    const basePath = isGithub ? `/${repoName}/` : `/${repoName}/`;
  
    const base = document.createElement("base");
    base.href = basePath;
    document.head.prepend(base);
  
    // Expose basePath to other scripts
    window.BASE_PATH = basePath;
  })();
  
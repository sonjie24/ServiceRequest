//const API_BASE_URL = "http://localhost:5678/webhook";
const API_BASE_URL = "https://f33f9373d24d.ngrok-free.app/webhook";

 
// Dynamically set the <base> tag for GitHub Pages vs local
// config.js
(function () {
    const repoName = "ServiceRequest-main"; // Update if needed
    const isGithub = window.location.hostname.includes("github.io");
  
    const basePath = isGithub ? `/${repoName}/` : '/';
  
    const base = document.createElement("base");
    base.href = basePath;
    document.head.prepend(base);
  
    // Expose basePath to other scripts
    window.BASE_PATH = basePath;
  })();
  
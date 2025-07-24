

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
  
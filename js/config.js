//const API_BASE_URL = "http://localhost:5678/webhook";
const API_BASE_URL = "https://f33f9373d24d.ngrok-free.app/webhook";

 
// Dynamically set the <base> tag for GitHub Pages vs local
(function() {
    const repoName = "ServiceRequest"; // Change this if your GitHub repo name is different
    const isGithub = window.location.hostname.includes("github.io");
  
    const base = document.createElement("base");
    base.href = isGithub ? `/${repoName}/` : "";
    document.head.prepend(base);
  })();
  
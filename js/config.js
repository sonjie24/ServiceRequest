(function () {
  const repoName = "ServiceRequest"; // Update if needed
  const hostname = window.location.hostname;

  let basePath = "";
  if (hostname.includes("github.io") || hostname.includes("20.20.40.221")) {
    // GitHub Pages can't make backend calls directly unless it's public API or proxied
    basePath = `/${repoName}/`;
  } else {
    basePath = "/";
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

  if (hostname.includes("20.20.40.221") || hostname.includes("127.0.0.1")) {
    apiBaseUrl = "http://20.20.40.221:5678/webhook"; // Fallback
  } else {
    // GitHub Pages can't make backend calls directly unless it's public API or proxied
    apiBaseUrl = "https://72effc5616a8.ngrok-free.app/webhook"; // Replace with real prod endpoint
  }

  // Expose API_BASE_URL to other scripts
  window.API_BASE_URL = apiBaseUrl;
})();



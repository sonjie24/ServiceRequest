(function () {
  const repoName = "ServiceRequest"; // Update if needed
  const hostname = window.location.hostname;

  // Set base path for GitHub Pages or local
  const isGithub = hostname.includes("github.io");
  const basePath = isGithub ? `/${repoName}/` : '/';

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

const WebSocket = require("ws");

const wss = new WebSocket.Server({ port: 8080 });

wss.on("connection", (ws) => {
  console.log("Client connected");

  ws.on("message", (data) => {
    const message = data.toString(); // 👈 Convert Buffer to string
    console.log("Received:", message);

    if (message === "refresh_masterlist") {
      // Broadcast to all connected clients
      wss.clients.forEach((client) => {
        if (client.readyState === WebSocket.OPEN) {
          client.send("refresh_masterlist");
        }
      });
    }
  });

  ws.on("close", () => {
    console.log("Client disconnected");
  });
});

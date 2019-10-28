const signalR = require("@microsoft/signalr");

let connection = new signalR.HubConnectionBuilder()
    .withUrl("http://localhost:5000/chat")
    .configureLogging(signalR.LogLevel.Information)
    .build();

    connection.start().then(function () {
    console.log("connected to service hub");
});

connection.on("BroadcastMessage", (message) => {
    console.log("recieved => " + message);
});

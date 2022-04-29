const serverAddress = "URL";
const serverConnection = new WebSocket(serverAddress);
let target = {x:0,y:0};

serverConnection.onopen = function() {
  console.log("connected "+serverAddress);
  serverConnection.send("#1");
}

function sendCoordinates() {
  
}

serverConnection.onmessage = function(event) {
  
}

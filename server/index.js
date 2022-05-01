const Websocket = require('ws')
const port=8080;
const wsServer = new WebSocket.Server({port:PORT})
var palyersData = {"type": "playerData"}

wsServer.on('open'){
    console.log("The server is listening on port " + wsServer.options.port);
}


wsServer.on('connection', function(client,req){
    client.id = 
  
    client.on('message', function(msg){
          wsServer.clients.forEach(function (clientss){
          clientss.send(""+msg);
        })
    })
})

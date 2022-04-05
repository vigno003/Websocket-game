const Websocket = require('ws')
const port=8080;
const wsServer = new WebSocket.Server({port:PORT})

console.log("The server is listening on port " + wsServer.options.port);

wsServer.on('connection', function(connessione,req){
    var ipClient= req.headers["x-forwarded-for"].split(',')[0];
    /*console.log(ipClient);
    console.log(req.socket.remotePort);
    console.log("si è connesso qualcuno");
    console.log("porta: "+req.socket.remotePort+" , indirizzo IP: "+ipClient);*/
  
    connessione.on('message', function(msg){
          wsServer.clients.forEach(function (client){
          client.send(""+msg);
        })
    })
})

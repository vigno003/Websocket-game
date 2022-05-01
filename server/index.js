const Websocket = require('ws')
const port=8080;
const wsServer = new WebSocket.Server({port:PORT})
var palyersData = {"type": "playerData"}
Random rnd = new Random();

wsServer.on('open'){
    console.log("The server is listening on port " + wsServer.options.port);
}


wsServer.on('connection', function(client,req){
    
    client.id = rnd.Next(1,100)*rnd.Next(1,100);
    playersData["" + client.id] = {id : client.id}
    client.send(`{"id": "${client.id}"`)
  
    client.on('message', (msg) => {
            var dataJSON = JSON.parse(data)
    
            console.log("Player Message")
            console.log(dataJSON)
        
            wsServer.clients.forEach(function (client){
            client.send(""+msg);
        })
        
        client.on('close', () => {
            console.log("Connection Closed")
            console.log("Log out client: "+ client.id)
        })
    })
})

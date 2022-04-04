const Websocket = require('ws')
const port=8080;
const ws= new Websocket.Server({port}, ()=>{
    console.log('server started')
})

ws.on('connection',(ws)=>[
    ws.on('message',(data)=>{
        console.log('data received:'+data)
        ws.send(""+data)
    })
])

ws.on('listening', ()=>{
    console.log('port '+port)
})
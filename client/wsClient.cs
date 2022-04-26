const serverAddress = "URL";
const serverConnection = new WebSocket(serverAddress);
let target = {x:0,y:0};

serverConnection.onopen = function() {
  console.log("connected "+serverAddress);
}

function sendCoordinates() {
  let norm ={
    x:target.x/width,
    y:target.y/height
  }
  let str=JSON.stringify(norm);
  //serverConnection.onopen = () => serverConnection.send(str);
  serverConnection.send(str);
}

serverConnection.onmessage = function(event) {
  console.log("move: "+event.data)
  let obj=JSON.parse(event.data);
  client=
  obj.x*=width;
  obj.y*=height;
  target.x=obj.x;
  target.y=obj.y;
}

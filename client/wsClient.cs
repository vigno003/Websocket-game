using WebSocketSharp;
using UnityEngine;
using Ninja.WebSockets;
using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class wsClient : MonoBehaviour
{
  var factory = new WebSocketClientFactory();
  WebSocket webSocket = await factory.ConnectAsync(new Uri("wss://example.com"));
  
  private async Task Receive(WebSocket webSocket)
  {
      var buffer = new ArraySegment<byte>(new byte[1024]);
      while (true)
    {
        WebSocketReceiveResult result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);
        switch (result.MessageType)
        {
            case WebSocketMessageType.Close:
                return;
            case WebSocketMessageType.Text:
            case WebSocketMessageType.Binary:
                string value = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                Console.WriteLine(value);
                break;
        }
     }
   }
   
   private async Task Send(WebSocket webSocket)
    {
      var array = Encoding.UTF8.GetBytes("Hello World");
      var buffer = new ArraySegment<byte>(array);
      await webSocket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
    } 
   
}

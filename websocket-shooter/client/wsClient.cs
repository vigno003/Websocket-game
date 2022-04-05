using WebSocketSharp;
using UnityEngine;

public class wsClient : MonoBehaviour
{
  WebSocket ws;
  void Start()
  {
    ws = new WebSocket("URL server");
    ws.OnMessage += (sender, e) =>
    {
      Debug.Log("Message received from "+((WebSocket)sender).Url + ", Data: " + e.Data);
    };
    ws.Connect();
  }
  
  void Update()
  {
    if(ws==null)
    {
      return;
    }
    if(Input.GetKeyDown(KeyCode.Space))
    {
      ws.Send("Hello");
    }
  }
}

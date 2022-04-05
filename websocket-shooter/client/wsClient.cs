using WebSocketSharp;
using UnityEngine;

public class wsClient : MonoBehaviour
{
  WebSocket ws;
  void Start()
  {
    ws = new WebSocket("URL server");
    ws.Connect();
    ws.OnMessage += (sender, e) =>
    {
      Debug.Log("Message received from "+((WebSocket)sender).Url + ", Data: " + e.Data);
    };
    string dataClient=e.Data;
    if(dataClient=="w")
    {
      Debug.Log("move forward");
    }
    else if(dataClient=="a")
    {
      Debug.Log("move left");
    }
    else if(dataClient=="s")
    {
      Debug.Log("move backward");
    }
    else if(dataClient=="d")
    {
      Debug.Log("move right");
    }
    else if(dataClient=="mouse0")
    {
      Debug.Log("shoot");
    }
  }
  
  void Update()
  {
    if(ws==null)
    {
      return;
    }
    if(Input.GetKeyDown(KeyCode.w))
    {
      ws.Send("w");
    }
    else if(Input.GetKeyDown(KeyCode.a))
    {
      ws.Send("a");
    }
    else if(Input.GetKeyDown(KeyCode.s))
    {
      ws.Send("s");
    }
    else if(Input.GetKeyDown(KeyCode.d))
    {
      ws.Send("d");
    }
    if(Input.GetKeyDown(KeyCode.Mouse0))
    {
      ws.Send("mouse0");
    }
  }
}

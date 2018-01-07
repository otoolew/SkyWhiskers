using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour {   
    //public List<Message> messageList = new List<Message>();
    public Message messageHolder;
    public MessageSO currentMessage;

    // Use this for initialization
    void Start () {
        //Debug.Log(message.);
        //message.GetComponent<Message>();
    }
	
	// Update is called once per frame
	void Update () {
        
        //message.SetPortraitImage(messageSO.sprite);
        //message.SetTextMessage(messageSO.textMessage);
    }
    public void Initialize(MessageSO selectedMessage)
    {
        currentMessage = selectedMessage;

        currentMessage.InitializeMessage(messageHolder);
    }


}

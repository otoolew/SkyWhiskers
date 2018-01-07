using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Speech/Message")]
public class MessageSO : ScriptableObject {
    //private Image _portraitImage;
    public string messageText;
    private Message messageHolder;
    public void InitializeMessage(Message obj)
    {
        messageHolder = obj.GetComponent<Message>();
        messageHolder.messageText.text = messageText;
    }
}

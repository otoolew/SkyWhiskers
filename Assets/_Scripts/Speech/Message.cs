using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    public Text messageText;
    private void Start()
    {
        messageText = GetComponent<Text>();
    }
    private void Update()
    {
        
    }
    public void Initialize()
    {
        messageText = GetComponent<Text>();
    }
}

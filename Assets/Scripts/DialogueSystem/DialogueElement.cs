using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueElement
{
    public bool hasDialog = false;
    public bool allowPlayerAdvance = true;
    public string speakerName;
    public string originalSpeakerName;
    public string dialogText;

    public override string ToString()
    {
        return "(" + this.hasDialog + ")" + this.speakerName + "::" + this.dialogText + "\n";
    }
}

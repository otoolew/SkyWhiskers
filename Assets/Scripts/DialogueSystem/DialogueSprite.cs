using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class DialogueSprite
{
    public Sprite sprite;
    [HideInInspector]
    public int lineWithSprite = -1;
    [HideInInspector]
    public int spritePosition = -1;
    public float width = 1;
    public float height = 1;
    [HideInInspector]
    public bool alreadyInPlace;
    public RuntimeAnimatorController animator;
}

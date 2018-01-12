using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
[AddComponentMenu("Dialogue/Utility/Dialogue Utility")]
public class DialogueUtility : MonoBehaviour
{
    public static void CopyTextParameters(Text original, Text copy)
    {
        //Replace every public option of the new text with the ancient one
        copy.text = original.text;
        copy.font = original.font;
        copy.fontStyle = original.fontStyle;
        copy.fontSize = original.fontSize;
        copy.lineSpacing = original.lineSpacing;
        copy.supportRichText = original.supportRichText;
        copy.alignment = original.alignment;
        copy.alignByGeometry = original.alignByGeometry;
        copy.horizontalOverflow = original.horizontalOverflow;
        copy.verticalOverflow = original.verticalOverflow;
        copy.resizeTextForBestFit = original.resizeTextForBestFit;
        copy.color = original.color;
        copy.material = original.material;
        copy.raycastTarget = original.raycastTarget;
    }

    public static int CountRichTextCharacters(string line)
    {
        int richTextCount = 0;
        //check for any rich text 
        if (line.IndexOf('<') != -1)
        {
            bool thereIsRichTextLeft = true;

            //repeat for as long as we find a tag
            while (thereIsRichTextLeft)
            {
                int inicialBracket = line.IndexOf('<');
                int finalBracket = line.IndexOf('>');
                //Here comes the tricky part... First check if there is any '<' before a '>'
                if (inicialBracket < finalBracket)
                {
                    //Ok, there is! It should be a tag. Let's count every char inside of it
                    richTextCount += finalBracket - inicialBracket + 1;


                    //Good! Now finaly, remove it from the original text
                    string textWithoutRichText = line.Substring(0, inicialBracket);
                    textWithoutRichText += line.Substring(finalBracket + 1);
                    line = textWithoutRichText;

                }
                else
                {
                    thereIsRichTextLeft = false;
                }
            }

        }

        return richTextCount;
    }

    public static int CountDialogueTagCharacters(string line)
    {
        int tagCount = 0;
        //check for any rich text 
        if (line.IndexOf('[') != -1)
        {
            bool thereAreTagsLeft = true;

            //repeat for as long as we find a tag
            while (thereAreTagsLeft)
            {
                int inicialBracket = line.IndexOf('[');
                int finalBracket = line.IndexOf(']');
                //Here comes the tricky part... First check if there is any '[' before a ']'
                if (inicialBracket < finalBracket)
                {
                    //Ok, there is! It should be a tag. Let's count every char inside of it
                    tagCount += finalBracket - inicialBracket + 1;


                    //Good! Now finaly, remove it from the original text
                    string textWithoutTag = line.Substring(0, inicialBracket);
                    textWithoutTag += line.Substring(finalBracket + 1);
                    line = textWithoutTag;

                }
                else
                {
                    thereAreTagsLeft = false;
                }
            }

        }

        return tagCount;
    }

#if UNITY_EDITOR
    [MenuItem("Dialogue/Create Dialogue/Base Instance %#r")]
    private static void CreateDialogueBase()
    {
        GameObject newGO = new GameObject();
        newGO.AddComponent<Dialogue>();
        newGO.name = "Dialogue Holder";
        Undo.RegisterCreatedObjectUndo(newGO, "Create Dialogue");
    }
#endif
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Randomtext : MonoBehaviour
{
    public Text text;
    public string[] strings;
    public string selectedText;
    public int i;

    void Start()
    {
        if (strings.Length > 0)
        {
            i = Random.Range(0, strings.Length); 
            selectedText = strings[i].ToUpper();

            // �ŧ���ٻẺ "[0] U, [1] N, [2] I, ..."
            string charPositions = string.Join(", ",System.Linq.Enumerable.Range(0, selectedText.Length).Select(index => $"[{index}] {selectedText[index]}"));

            text.text = $"Text : {selectedText}\n\nCharacter Positions:\n{charPositions}";
        }
        Debug.Log(selectedText[0]);
        Debug.Log(selectedText[1]);
        Debug.Log(selectedText[2]);
        Debug.Log(selectedText[3]);
        Debug.Log(selectedText[4]);
    }
}

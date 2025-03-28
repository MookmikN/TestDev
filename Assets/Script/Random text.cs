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
    private int i;

    void Start()
    {
        if (strings.Length > 0)
        {
            i = Random.Range(0, strings.Length); 
            selectedText = strings[i].ToUpper();
            string charPositions = string.Join(", ",System.Linq.Enumerable.Range(0, selectedText.Length).Select(index => $"[{index}] {selectedText[index]}"));

            text.text = $"Vocabulary : {selectedText}\n\nCharacter Positions:\n{charPositions}";
        }
    }
}

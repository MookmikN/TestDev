using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using TMPro;
using UnityEditor;
using Unity.VisualScripting;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using UnityEngine.Windows;

public class WordleGame : MonoBehaviour
{
    public int num = 5;  // กำหนดให้คำมี 5 ตัวอักษร
    public InputField PfBoxtext;
    public Transform Transform;
    public List<InputField> createdPfBoxtext = new List<InputField>();
    private int currentRow = 0;
    private int currentColumn = 0;
    public Image[] ButtomImage;
    public string targetWord ;
    private List<char> createdChar = new List<char>();
    public GameObject win;
    public GameObject lose;
    public Randomtext RDT;

    private void Start()
    {
        GenerateInputFields();
        targetWord = RDT.selectedText.ToUpper();
    }

    public void GenerateInputFields()
    {
        int x = 0, y = 0;
        for (int j = 0; j < 6; j++) // 6 แถว
        {
            for (int i = 0; i < num; i++) // 5 คำต่อแถว
            {
                InputField newPF = Instantiate(PfBoxtext, transform);
                createdPfBoxtext.Add(newPF);
                newPF.transform.position += new Vector3(x, y, 0);
                x += 45;
            }
            x = 0;
            y -= 45;
        }
    }

    public void AddLetter(char letter)
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = letter.ToString();
                currentColumn++;
                createdChar.Add(letter);
            }
        }
    }

    public void DEL()
    {
        if (currentColumn > 0)
        {
            currentColumn--;
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "";
                createdChar.RemoveAt(createdChar.Count - 1);
            }
        }
    }

    public void Enter()
    {
        if (createdChar.Count != num) return; // หากคำไม่ครบ 5 ตัวอักษร

        string createdWord = new string(createdChar.ToArray());

        // เปรียบเทียบกับคำตอบ (targetWord)
        CheckWord(createdWord);

        // ถ้าคำถูกต้อง ให้เพิ่มแถวใหม่
        if (createdWord == targetWord)
        {
            Debug.Log("You Win!");
            win.SetActive(true);
            foreach (Image image in ButtomImage)
            {
                image.color = Color.green;
            }
        }
        else
        {
            currentRow++;
            currentColumn = 0;
            createdChar.Clear();

            if (currentRow >= 6) // เมื่อครบ 6 แถว ผู้เล่นแพ้
            {
                lose.SetActive(true);
            }
        }
    }

    private void CheckWord(string createdWord)
    {
        for (int i = 0; i < num; i++)
        {
            char currentChar = createdWord[i];
            if (currentChar == targetWord[i]) // ตัวอักษรตรงกันที่ตำแหน่งเดียวกัน
            {
                createdPfBoxtext[(currentRow * num) + i].image.color = Color.green;
            }
            else if (targetWord.Contains(currentChar.ToString())) // ตัวอักษรอยู่ในคำแต่ไม่อยู่ในตำแหน่งที่ถูกต้อง
            {
                createdPfBoxtext[(currentRow * num) + i].image.color = Color.yellow;
            }
            else // ตัวอักษรไม่อยู่ในคำเลย
            {
                createdPfBoxtext[(currentRow * num) + i].image.color = Color.gray;
            }
        }
    }

    public void KeyQ() { AddLetter('Q'); }
    public void KeyW() { AddLetter('W'); }
    public void KeyE() { AddLetter('E'); }
    public void KeyR() { AddLetter('R'); }
    public void KeyT() { AddLetter('T'); }
    public void KeyY() { AddLetter('Y'); }
    public void KeyU() { AddLetter('U'); }
    public void KeyI() { AddLetter('I'); }
    public void KeyO() { AddLetter('O'); }
    public void KeyP() { AddLetter('P'); }
    public void KeyA() { AddLetter('A'); }
    public void KeyS() { AddLetter('S'); }
    public void KeyD() { AddLetter('D'); }
    public void KeyF() { AddLetter('F'); }
    public void KeyG() { AddLetter('G'); }
    public void KeyH() { AddLetter('H'); }
    public void KeyJ() { AddLetter('J'); }
    public void KeyK() { AddLetter('K'); }
    public void KeyL() { AddLetter('L'); }
    public void KeyZ() { AddLetter('Z'); }
    public void KeyX() { AddLetter('X'); }
    public void KeyC() { AddLetter('C'); }
    public void KeyV() { AddLetter('V'); }
    public void KeyB() { AddLetter('B'); }
    public void KeyN() { AddLetter('N'); }
    public void KeyM() { AddLetter('M'); }
}
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

public class CheckKeyboard : MonoBehaviour
{
    public int num;
    private int i;
    private int j;
    private int x = 0;
    private int y = 0;
    public InputField PfBoxtext;
    public Transform Transform;
    public List<InputField> createdPfBoxtext = new List<InputField>();
    private int currentRow = 0;
    private int currentColumn = 0;
    public Image[] ButtomImage;
    public Randomtext RDT;
    private void Start()
    {
        GenerateInputFields();
    }

    public void GenerateInputFields()
    {

        for (j = 0; j < 6; j++)
        {
            for ( i = 0; i < num; i++)
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

    private void Update()
    {
        
    }


    public void KeyQ()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count) 
            {
                createdPfBoxtext[index].text = "Q";
                currentColumn++;
            }  
        }
       
    }
    public void KeyW()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "W";
                currentColumn++;
            }
        }
    }
    public void KeyE()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "E";
                currentColumn++;
            }

        }
    }
    public void KeyR()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "R";
                currentColumn++;
               
            }

        }
    }
    public void KeyT()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "T";
                currentColumn++;
               
            }

        }
    }
    public void KeyY()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "Y";
                currentColumn++;
               
            }

        }
    }
    public void KeyU()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "U";
                currentColumn++;
                
            }

        }
    }
    public void KeyI()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "I";
                currentColumn++;
                
            }

        }
    }
    public void KeyO()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "O";
                currentColumn++;
                
            }

        }
    }
    public void KeyP()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "P";
                currentColumn++;
               

            }
        }
    }
    public void KeyA()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "A";
                currentColumn++;
              
            }

        }
    }
    public void KeyS()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "S";
                currentColumn++;
                
            }

        }
    }
    public void KeyD()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "D";
                currentColumn++;
                
            }

        }
    }
    public void KeyF()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "F";
                currentColumn++;
               
            }

        }
    }
    public void KeyG()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "G";
                currentColumn++;
               
            }

        }
    }
    public void KeyH()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "H";
                currentColumn++;
                
            }

        }
    }
    public void KeyJ()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "J";
                currentColumn++;
                
            }

        }
    }
    public void KeyK()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "K";
                currentColumn++;
               
            }

        }
    }
    public void KeyL()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "L";
                currentColumn++;
               
            }

        }
    }
    public void KeyZ()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "Z";
                currentColumn++;
               
            }

        }
    }
    public void KeyX()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "X";
                currentColumn++;
               
            }

        }
    }
    public void KeyC()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "C";
                currentColumn++;
              
            }

        }
    }
    public void KeyV()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "V";
                currentColumn++;
              
            }

        }
    }
    public void KeyB()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "B";
                currentColumn++;
             
            }

        }
    }
    public void KeyN()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "N";
                currentColumn++;
             
            }

        }
    }
    public void KeyM()
    {
        if (currentColumn < num)
        {
            int index = (currentRow * num) + currentColumn;
            if (index < createdPfBoxtext.Count)
            {
                createdPfBoxtext[index].text = "M";
                currentColumn++;
             
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
            }
        }
    }

    public void Enter()
    {
        // ตรวจสอบว่าแถวปัจจุบันกรอกครบทุกช่องแล้วหรือไม่
        bool isRowComplete = true;
        for (int i = 0; i < num; i++)
        {
            int index = (currentRow * num) + i; // คำนวณตำแหน่งของช่องในแถวปัจจุบัน
            if (index < createdPfBoxtext.Count && string.IsNullOrEmpty(createdPfBoxtext[index].text))
            {
                isRowComplete = false; // ถ้ามีช่องไหนที่ยังกรอกไม่ครบ จะไม่สามารถไปแถวใหม่ได้
                break;
            }
        }

        // ถ้ากรอกครบทุกช่องในแถวแล้ว จะไปแถวใหม่
        if (isRowComplete)
        {

        }

    }

}

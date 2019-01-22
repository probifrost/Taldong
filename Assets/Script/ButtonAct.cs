using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonAct : MonoBehaviour
{
    public GameObject Button;
    public GameObject LeftButton;
    public GameObject RightButton;
    private BGImage current;
    private int Cur;


    // Use this for initialization
    void Start()
    {
        
        current = GameObject.Find("BackgroundImage").GetComponent<BGImage>();
        Cur = Int32.Parse(current.currentImage); //Cur은 string인 currentImage를 정수로 형변환 한것.
    }

    public void RightClick()
    {
        Cur += 1;
        if(Cur == 5)
        {
            Cur = 1;
        }
        current.currentImage = Cur.ToString(); //다시 ToString()으로 문자열로 형변환.
    }
    public void LeftClick()
    {
        Cur -= 1;
        if(Cur == 0)
        {
            Cur = 4;
        }
        current.currentImage = Cur.ToString();
    }
    public void BackClick()
    {
        string back = current.currentImage.Remove(1, 2); //#-%형식의 문자열에서 뒤의 -%를 지워서 돌려보낸다. 
        current.currentImage = back;

        Debug.Log(current.currentImage); //디버그

        Button.SetActive(false);
        LeftButton.SetActive(true);
        RightButton.SetActive(true);
    }
}
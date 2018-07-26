using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAct : MonoBehaviour
{
    public GameObject Button;
    public GameObject LeftButton;
    public GameObject RightButton;
    private BGImage current;


    // Use this for initialization
    void Start()
    {
        current = GameObject.Find("BackgroundImage").GetComponent<BGImage>();
    }

    public void RightClick()
    {
        current.CurrentImage += 1;
    }
    public void LeftClick()
    {
        current.CurrentImage -= 1;
    }
    public void BackClick()
    {
        current.CurrentImage -= 5;
        Button.SetActive(false);
        LeftButton.SetActive(true);
        RightButton.SetActive(true);
    }
}
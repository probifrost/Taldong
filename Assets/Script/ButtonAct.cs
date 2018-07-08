using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAct : MonoBehaviour
{
    public GameObject Button;
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
    public void lefttClick()
    {
        current.CurrentImage -= 1;
    }
    public void backClick()
    {
        current.CurrentImage -= 5;
        Button.gameObject.SetActive(false);
    }
}
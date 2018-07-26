using System;
using System.Collections.Generic;
using UnityEngine;


public class ZoomInObj : MonoBehaviour
{
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject BackButton;

    private BGImage current;

    void Start()
    {
        current = GameObject.Find("BackgroundImage").GetComponent<BGImage>();
    }
    public void ZoomClick()
    {
        current.CurrentImage += 5;
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
        BackButton.SetActive(true);
    }
    
}

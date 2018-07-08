using System;
using System.Collections.Generic;
using UnityEngine;


public class ZoomInObj : MonoBehaviour
{
    public GameObject BackButton;

    private BGImage current;

    void Start()
    {
        current = GameObject.Find("BackgroundImage").GetComponent<BGImage>();
    }
    public void ChangeBG()
    {
        current.CurrentImage += 5;
        BackButton.SetActive(true);
    }
    
}

using System;
using System.Collections.Generic;
using UnityEngine;


public class ZoomInObj : MonoBehaviour
{
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject BackButton;

    public int index;

    private List<int> list = new List<int>() {0, 1, 2, 3, 4};
    private BGImage current;

    void Start()
    {
        current = GameObject.Find("BackgroundImage").GetComponent<BGImage>();
    }
    public void ZoomClick()
    {
        //배경화면 변경
        string save = current.pastImage;
        save += "-" + list[index];
        current.currentImage = save;

        Debug.Log(current.currentImage); //디버그

        //버튼 액티브 변경
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
        BackButton.SetActive(true);

        
    }
    
}

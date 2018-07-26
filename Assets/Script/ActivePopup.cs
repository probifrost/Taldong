using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ActivePopup : MonoBehaviour{

    public GameObject PopupObj;

    void Start()
    {
        PopupObj.SetActive(false);
    }


    public void Popup()
    {
        PopupObj.SetActive(true);
    }

    public void Popout()
    {
        PopupObj.SetActive(false);
    }
}

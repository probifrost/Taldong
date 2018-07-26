using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{

    private int currentValue;
    private int value;

    public int CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            if (value == 10)
            {
                currentValue = 0;
            }
            else
            {
                currentValue = value;
            }
        }
    }

    public void Number100()
    {
        var Number = GameObject.Find("LockNumber100");
        Number.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Number" + currentValue.ToString());
    }
    public void Number10()
    {
        var Number = GameObject.Find("LockNumber10");
        Number.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Number" + currentValue.ToString());
    }
    public void Number1()
    {
        var Number = GameObject.Find("LockNumber1");
        Number.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Number" + currentValue.ToString());
    }


}
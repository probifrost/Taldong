using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine

public class LockNum : MonoBehaviour
{
    private Lock current;

    void Start()
    {
        current = this.gameObject.GetComponent<Lock>();
    }
    public void IncreaseNum()
    {
        current.CurrentValue += 1;
    }
} 

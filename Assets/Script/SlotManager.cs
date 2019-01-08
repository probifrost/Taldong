using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour {

    void Start()
    {
        InitInven();
    }

	void InitInven()
    {
        
        var slots = GameObject.Find("Slots");
        foreach(Transform slot in slots.transform)
        {
            slot.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Inventory/empty_item");
        }
    }
}

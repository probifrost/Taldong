using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item_PickUp : MonoBehaviour {

    public string displayitem;
    private GameObject InventorySlots;
    private string[] itemlist = {"BatteryOmega","BatteryAlpha","BatteryRho","BatteryPsi","BatteryKappa","testimage"};

    void Update()
    {
        
    }
    void Start()
    {
        InventorySlots = GameObject.Find("Slots");
        Pickup();
    }
    void Pickup()
    {
        int id= GetID(displayitem);
        Debug.Log(InventorySlots);
        Debug.Log(id);
        InventorySlots.transform.GetChild(id).GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/testimage");
        Debug.Log("Inventory/"+displayitem);      
        Destroy(this.gameObject);
    }
    int GetID(string itemname)
    {
        for(int i = 0; i <= itemlist.Length; i++)
        {
            if(itemlist[i] == itemname)
            {
                return i;
            }
        }
        return -1;
    }
}

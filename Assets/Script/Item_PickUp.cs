using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item_PickUp : MonoBehaviour, IInteratable {

    public string displayitem;
    private GameObject InventorySlots;

    public void Interact(BGImage currentImage)
    {
        Pickup();
    }
    void Start()
    {
        InventorySlots = GameObject.Find("Slots");
    }
    void Pickup()
    {
        foreach(Transform slot in InventorySlots.transform)
        {
            if (slot.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "empty_item")
            {
                slot.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Inventory/" + displayitem);
            }
        }
    }
}

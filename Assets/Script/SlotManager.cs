using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SlotManager : MonoBehaviour {

    public bool[] enbflg = new bool[12];

    private GameObject slots;

    void Start()
    {
        InitInven();
    }

	void InitInven()
    {
        GameObject slots = GameObject.Find("Slots");
        foreach (Transform slot in slots.transform)
        {
            slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/empty_item");
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 클릭이 감지되면
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y); //마우스 포지션을 mousePos2d에 저장

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero); //hit = mousePos2d를 가리킴

            if (hit.collider != null &&
                hit.collider.transform.tag == "Inven" && 
                hit.collider.transform.GetChild(0).GetComponent<Image>().sprite != Resources.Load<Sprite>("Inventory/empty_item")) //hit.collier가 있고, 그 부모가 slots고 그 자식의 이미지가 empty_item이 아닐때
            {
                Itemuse(hit.collider.gameObject);
            }
        }
    }
    void Itemuse(GameObject obj)
    {
        Debug.Log(obj.name);
        int slotnum = Int32.Parse(obj.name.Remove(0,4));
        Debug.Log(slotnum);
        if (obj.transform.GetComponent<Image>().sprite == Resources.Load<Sprite>("Sprites/ETC/인벤슬롯"))
        {
            obj.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/ETC/인벤슬롯2");
            enbflg[slotnum] = true;
        }
        else
        {
            obj.transform.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/ETC/인벤슬롯");
            enbflg[slotnum] = false;
        }
          
    }
}

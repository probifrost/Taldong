using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item_PickUp : MonoBehaviour {

    public string displayitem;
    private GameObject InventorySlots;
    //private string[] itemlist = {"BatteryOmega","BatteryAlpha","BatteryRho","BatteryPsi","BatteryKappa","testimage"};
    private Itemlist Aitemlist;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 클릭이 감지되면
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y); //마우스 포지션을 mousePos2d에 저장

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero); //hit = mousePos2d를 가리킴

            if (hit.collider != null) //만약 hit 위치에 collider가 있다면
            {
                Debug.Log(hit.collider.gameObject.name); //디버그를 띄우고
                Pickup(); //픽업을 실행
            }
        }
    }

    void Start()
    {
        InventorySlots = GameObject.Find("Slots"); //인벤토리 슬롯을 발견
        Aitemlist = GameObject.Find("ItemManager").GetComponent<Itemlist>();
    }

    void Pickup()
    {
        Debug.Log("Start"); //픽업이 시작되는지 로그
        int id= GetID(displayitem); //아이템의 id를 받아옴
        Debug.Log(id);

        InventorySlots.transform.GetChild(id).GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/"+Aitemlist.Allitemlist[id]); //받아온 아이템id를 기준으로 이미지를 변경
        Destroy(this.gameObject); //이 오브젝트를 파괴
    }

    int GetID(string itemname)
    {
        for(int i = 0; i <= Aitemlist.Allitemlist.Length; i++)
        {
            if(Aitemlist.Allitemlist [i] == itemname)
            {
                return i;
            }
        }
        return -1;
    }
}

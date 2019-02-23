using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagScript : MonoBehaviour
{
    public static bool flag;
    private GameObject Rho;
    private Itemlist Aitemlist;

    private void Start()
    {
        Rho = GameObject.Find("Rho");
    }

    private void Update()
    {
        if (flag)
        {
            if (Input.GetMouseButtonDown(0)) //마우스 클릭이 감지되면
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y); //마우스 포지션을 mousePos2d에 저장

                RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero); //hit = mousePos2d를 가리킴
                if (hit.collider != null &&
                    hit.collider.gameObject == this.gameObject) //만약 hit이 이 물체
                {
                    Debug.Log(hit.collider.gameObject.name); //디버그를 띄우고
                    Ruler();
                }
            }
        }
        
    }
    void Ruler() //자에서 배터리를 꺼내서 인벤에 넣어주세요.
    {
        Item_PickUp item = new Item_PickUp();
        item.Pickup(Rho);

    }


}


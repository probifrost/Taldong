using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterEvent : MonoBehaviour {

    // 포스터를 클릭하면 액자 창이 뜨고 '자가 담긴 통'을 활성화
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 클릭이 감지되면
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y); //마우스 포지션을 mousePos2d에 저장

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero); //hit = mousePos2d를 가리킴
            if (hit.collider == this.gameObject&&
                hit.collider.gameObject.layer == 8) //만약 hit 위치에 collider가 있고, 부모가 인벤토리가 아니며, 레이어가 8이 아닌 물체
            {
                Debug.Log(hit.collider.gameObject.name); //디버그를 띄우고
                
            }
        }
    }
}

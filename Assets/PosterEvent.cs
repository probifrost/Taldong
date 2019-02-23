using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterEvent : MonoBehaviour {

    private GameObject Poem;
    private GameObject RulerTong;
    private GameObject Poster;

    private void Start()
    {
        Poem = GameObject.Find("Poem");
        //RulerTong = GameObject.Find("RulerTong");
        //Poster = GameObject.Find("Poster");

        Poem.SetActive(false);
        flagScript.flag = false;
        Debug.Log(flagScript.flag);
    }

    // 포스터를 클릭하면 액자 창이 뜨고 자가담긴 통 메세지 변경
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 클릭이 감지되면
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y); //마우스 포지션을 mousePos2d에 저장

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero); //hit = mousePos2d를 가리킴
            if (hit.collider != null && hit.collider.gameObject.name == "Poster" && hit.collider.gameObject.layer == 8
                && Poem.activeSelf == false) //만약 hit이 이 물체라면
            {
                Debug.Log(hit.collider.gameObject.name); //디버그를 띄우고
                Postevent();
                
            }
        }
    }
    void Postevent()
    {
        Poem.SetActive(true);
        flagScript.flag = true;
        Debug.Log(flagScript.flag);
    }
}

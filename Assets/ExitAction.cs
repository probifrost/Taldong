using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAction : MonoBehaviour {

    private GameObject Poem;

    void Start(){
        Poem = GameObject.Find("Poem");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y); //마우스 포지션을 mousePos2d에 저장

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero); //hit = mousePos2d를 가리킴
            if (hit.collider != null && hit.transform.gameObject.tag == "Exit")
            {
                Exit();
            }
        }
    }

    void Exit()
    {
        Debug.Log("Click");
        Poem.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomIndexing : MonoBehaviour {

    public int n;
    public GameObject Button;
    public GameObject LeftButton;
    public GameObject RightButton;

    private CameraMove cameraMove;
    private GameObject cam;
    private Ray ray;
    private RaycastHit hit;

    private void Start()
    {
        cam = GameObject.Find("Main Camera");
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 클릭이 감지되면
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y); //마우스 포지션을 mousePos2d에 저장

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero); //hit = mousePos2d를 가리킴
            if (hit.collider != null && hit.collider.gameObject.layer == 9)
            {
                cam.GetComponent<Camera>().transform.position += Vector3.up * 10 * n;

                Button.SetActive(true);
                LeftButton.SetActive(false);
                RightButton.SetActive(false);
            }
        }
    }
}

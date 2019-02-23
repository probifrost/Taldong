using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject Button;
    public GameObject LeftButton;
    public GameObject RightButton;

    // Use this for initialization
    void Start () {
        transform.position = new Vector3(0, 0, -116);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CameraRight()
    {
        if(transform.position.x < 45)
        {
            transform.position += Vector3.right * 15;
        }
        else
        {
            transform.position = new Vector3(0, 0, -116);
        }
        
    }
    public void CameraLeft()
    {
        if (transform.position.x > 0)
        {
            transform.position += Vector3.left * 15;
        }
        else
        {
            transform.position = new Vector3(45, 0, -116);
        }
    }
    public void CameraBack()
    {
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x, 0, pos.z);

        Button.SetActive(false);
        LeftButton.SetActive(true);
        RightButton.SetActive(true);
    }
    public void CameraUp(int n)
    {
        transform.position += Vector3.up * 10 * n;

        Button.SetActive(true);
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
    }
}

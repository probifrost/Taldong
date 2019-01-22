using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BGImage : MonoBehaviour {

    public string currentImage;
    public string pastImage;
	// Use this for initialization
	void Start ()
    {
        currentImage = "1";
        pastImage = "0";
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(currentImage != pastImage)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Room" + currentImage);

         //관련 오브젝티브 변경 (방별로 태그를 달아서 태그에 해당하는 오브젝트를 Active/Deactive 식으로 구상)

            //pastimage obj -> Deactive
            foreach (GameObject gobj in FindInActiveObjectsByTag("room"+pastImage))
            {
                gobj.SetActive(false);
            }
            //currentimage obj -> Active
            foreach (GameObject gobj in FindInActiveObjectsByTag("room" + currentImage))
            {
                gobj.SetActive(true);
            }
        }
        pastImage = currentImage;
	}
    GameObject[] FindInActiveObjectsByTag(string tag)
    {
        List<GameObject> validTransforms = new List<GameObject>();
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].gameObject.CompareTag(tag))
                {
                    validTransforms.Add(objs[i].gameObject);
                }
            }
        }
        return validTransforms.ToArray();
    }
}

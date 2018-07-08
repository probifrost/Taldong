using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGImage : MonoBehaviour {

    public int CurrentImage
    {
        get {return currentImage; }
        set
        {
            if (value == 5)
                currentImage = 1;
            else if (value == 0)
                currentImage = 4;
            else
                currentImage = value;

        }
    }
    private int currentImage;
    private int pastImage;
	// Use this for initialization
	void Start ()
    {
        currentImage = 1;
        pastImage = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(currentImage != pastImage)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Room" + currentImage.ToString());
        }
        pastImage = currentImage;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG2 : MonoBehaviour {

    public static List<string> Bglist = new List<string>();

    public class bgimage
    {
        string name;
        int val;
        bgimage next;
        bgimage prev;

        public bgimage(string Name, int Num)
        {
            name = Name;
            val = Num;
            Bglist.Add(name);
        }

    }

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}

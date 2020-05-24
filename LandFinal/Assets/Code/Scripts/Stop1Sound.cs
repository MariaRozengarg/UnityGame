using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop1Sound : MonoBehaviour {

    public AudioSource sourse;
    float check;
    // Use this for initialization
    void Start ()
    {
		
	}

	void Update ()
    {
        check = GameObject.Find("CarMain").GetComponent<Escape1Script>().timing;

        if (check == 1)
        {
            sourse = GetComponent<AudioSource>();
            sourse.enabled = true;
        }
        else if (check == 0)
        {
            sourse = GetComponent<AudioSource>();
            sourse.enabled = false;
        }
    }
}

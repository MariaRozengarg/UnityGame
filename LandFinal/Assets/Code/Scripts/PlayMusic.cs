using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {

    public AudioSource audioSource;
    public static bool muze;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        if (muze == false)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            muze = true;
        }
        else if (muze == true)
        {
            audioSource.Stop();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

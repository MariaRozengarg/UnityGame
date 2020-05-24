using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCoffin : MonoBehaviour {

	public string nameTrigger;
    public GameObject coffin;
    private AudioSource audioR;
    private GameObject trigger;


	void OnTriggerEnter(Collider other)
	{
		// if (Input.GetKeyDown(KeyCode.E))
		// {
			if (other.tag == "Player"){
				coffin.GetComponent<Animator>().SetTrigger(nameTrigger);

		        audioR = GameObject.Find("PivotFront").GetComponent<AudioSource>();
  				audioR.Play();	

  				trigger = GameObject.Find("TriggerCoffin");
		        trigger.SetActive(false);
			}

		//}

	}
}

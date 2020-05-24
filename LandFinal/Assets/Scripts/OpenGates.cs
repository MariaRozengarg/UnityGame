using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGates : MonoBehaviour {

	public string nameTrigger;
    public GameObject gates;
    public GameObject chain;
    public GameObject oldLock;

    private AudioSource audioR;
    private GameObject trigger;


	void OnTriggerEnter(Collider other)
	{
		// if (Input.GetKeyDown(KeyCode.E))
		// {
			if (other.tag == "Player"){
				oldLock.GetComponent<Animator>().SetTrigger(nameTrigger);
				chain.GetComponent<Animator>().SetTrigger(nameTrigger);
				gates.GetComponent<Animator>().SetTrigger(nameTrigger);
				

		        audioR = GameObject.Find("PivotDoor").GetComponent<AudioSource>();
  				audioR.Play();	

  				trigger = GameObject.Find("TriggerDoor");
		        trigger.SetActive(false);
			}

		//}

	}
}

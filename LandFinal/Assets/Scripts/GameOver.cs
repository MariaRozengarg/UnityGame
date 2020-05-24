using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	public class GameOver : MonoBehaviour {

	    public GameObject textGameOver;
	    public GameObject imageBack;


		void OnTriggerEnter(Collider other)
		{
			if (other.tag == "Player"){
	            imageBack.SetActive(true);
	            textGameOver.SetActive(true);

	            GameObject player = GameObject.Find("FPSController");
	            FirstPersonController control = player.GetComponent<FirstPersonController>();
	            control.enabled = false;
			}
		}
	}
}

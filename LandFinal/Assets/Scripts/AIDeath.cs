using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIDeath : MonoBehaviour {

	public GameObject player;
	public float dist;

	NavMeshAgent nav;
	public float rad = 10;


	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance(player.transform.position, transform.position);
		if (dist > rad){
			nav.enabled = false;
		}
		if (dist < rad){
			nav.enabled = true;
			nav.SetDestination(player.transform.position);
		}
	}


}

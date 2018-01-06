﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public GameObject[] traps;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			foreach (GameObject trap in traps) {
				Debug.Log ("Activate " + trap.gameObject.name);
				trap.gameObject.GetComponent<TrapManager> ().activateTrap ();//change name to trapManager if want to re-use button
			}
		}
	}
}

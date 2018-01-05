using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillManager : MonoBehaviour {

	public GameObject windmillHead;
	public float rotationSpeed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		windmillHead.transform.Rotate(0,rotationSpeed * Time.deltaTime,0);
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player")
			Debug.Log ("DEAD!");
	}
}

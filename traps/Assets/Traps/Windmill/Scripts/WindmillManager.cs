using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillManager : MonoBehaviour {

	public GameObject windmillHead;
	public float rotationSpeed = 10;
	public float initDelay = 0;
	public bool opositeDirection = false;
	bool activated = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (activated) {
			if(!opositeDirection)
				windmillHead.transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
			else
				windmillHead.transform.Rotate (0, rotationSpeed * Time.deltaTime * -1.0f, 0);
		}else {
			if (initDelay >= 0) {
				initDelay -= Time.deltaTime;
			} else {
				activated = true;
			}

		}
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player")
			Debug.Log ("DEAD!");
	}
}

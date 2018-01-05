using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToothsManager : MonoBehaviour {

	// Use this for initialization
	public bool continuous = true;
	public float interval = 3.0f;
	public float toothHeight = 1f;
	public GameObject tooths;
	bool retract = false;
	public float actionTime = 1;
	float timePassed = 0.0f;
	float retractionSpeed = 0.0f;
	float toothSpeed = 0.0f;


	void Start () {
		toothSpeed = toothHeight / (actionTime/3);
		retractionSpeed = toothHeight / ((actionTime/4) * 3);
		Debug.Log ("Tooth Speed: " + toothSpeed);
		Debug.Log ("Retraction Speed: " + retractionSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		timePassed += Time.deltaTime;

		if (timePassed > interval) {
			if (!retract) {
				tooths.transform.Translate (Vector3.up * toothSpeed * Time.deltaTime);
				if (tooths.transform.position.y >= (gameObject.transform.position.y + toothHeight)) {					
					retract = true;
				}
			}
			else {
				tooths.transform.Translate (Vector3.down * retractionSpeed * Time.deltaTime);
				if (tooths.transform.position.y <= gameObject.transform.position.y) {
					retract = false;
					timePassed = 0;
				}
			}
	
		} else {
			Debug.Log (timePassed);
		}

	}
}

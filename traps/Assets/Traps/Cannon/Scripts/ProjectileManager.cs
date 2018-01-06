using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour {

	private bool destroyProjectile = false;
	public float dissapearTime = 1f;
	float timePassed = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timePassed += Time.deltaTime;
		if ((timePassed > dissapearTime) && (destroyProjectile)) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision col){

		if (col.collider.tag == "Player") {
			Debug.Log ("DEAD!");
		} else {
			//Debug.Log ("Collision!");
			if (!destroyProjectile) {
				timePassed = 0;
				destroyProjectile = true;
			}
		}
	}
}

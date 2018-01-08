using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour {
	public GameObject projectile;
	public GameObject cannon1;
	public GameObject cannon2;
	public GameObject cannon3;
	public GameObject cannon4;
	public GameObject projectilesParent;
	public float projectileSpeed = 300;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void activateTrap(){
		GameObject shot = Instantiate (projectile, cannon1.transform.position, Quaternion.Euler(new Vector3(0,0,-90))) as GameObject;
		shot.transform.parent = projectilesParent.gameObject.transform;
		shot.GetComponent<Rigidbody> ().AddForce (cannon1.transform.up * projectileSpeed);

		GameObject shot2 = Instantiate (projectile, cannon2.transform.position, Quaternion.Euler(new Vector3(0,0,-90))) as GameObject;
		shot2.transform.parent = projectilesParent.gameObject.transform;
		shot2.GetComponent<Rigidbody> ().AddForce (cannon2.transform.up * projectileSpeed);

		GameObject shot3 = Instantiate (projectile, cannon3.transform.position, Quaternion.Euler(new Vector3(0,0,-90))) as GameObject;
		shot3.transform.parent = projectilesParent.gameObject.transform;
		shot3.GetComponent<Rigidbody> ().AddForce (cannon3.transform.up * projectileSpeed);

		GameObject shot4 = Instantiate (projectile, cannon4.transform.position, Quaternion.Euler(new Vector3(0,0,-90))) as GameObject;
		shot4.transform.parent = projectilesParent.gameObject.transform;
		shot4.GetComponent<Rigidbody> ().AddForce (cannon4.transform.up * projectileSpeed);
	}
}

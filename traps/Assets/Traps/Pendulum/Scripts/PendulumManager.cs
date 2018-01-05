using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumManager : MonoBehaviour {

    public float maxAngle = 45.0f;
    public float angleSpeed = 25.0f;
    public float startReductionAngle = 10.0f;
    float angle;
    float deltaAngle;
    float realtimeSpeed;
    float reduction = 1;

    int factor = -1;
    // Use this for initialization
    void Start () {
        angle = maxAngle;
        gameObject.transform.Rotate(Vector3.forward, angle);
	}
	
	// Update is called once per frame
	void Update () {
        
        realtimeSpeed = angleSpeed * (reduction);
        deltaAngle = realtimeSpeed * Time.deltaTime * factor;
        angle += deltaAngle;
        //Debug.Log(angle);
        gameObject.transform.Rotate(Vector3.forward * deltaAngle);
        if (factor > 0) {
            if (angle >= (maxAngle * factor))
                factor *= -1;
        }
        else
        {
            if (angle <= (maxAngle * factor))
                factor *= -1;

        }
        
        
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player")
			Debug.Log ("DEAD!");
	}
}

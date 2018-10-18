using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CirclingEnemy : MonoBehaviour {

	public float rayDist;
	public float rotSpeed;
	public LineRenderer lineOfSight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (Vector3.forward * rotSpeed * Time.deltaTime);
		RaycastHit2D hitDetection = Physics2D.Raycast (transform.position, transform.right, rayDist);	



		if (hitDetection.collider != null) { //if something is detected
			Debug.DrawLine (transform.position, hitDetection.point, Color.red);
		} else {
			Debug.DrawLine (transform.position, transform.position + transform.right * rayDist, Color.red);
		}

			if(hitDetection.collider.CompareTag("Player")) {
			Debug.Log ("hit detected with player");
			Destroy (hitDetection.collider.gameObject);
		}

	}
}

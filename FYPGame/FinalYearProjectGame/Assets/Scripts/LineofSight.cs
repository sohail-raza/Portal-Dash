using UnityEngine;
using System.Collections;

public class LineofSight : MonoBehaviour {

	// Use this for initialization

	//public float rotSpeed;

	public Transform  enemySightStart, enemySightEnd;
	public bool isSpotted = false;
	public float moveSpeed;
	private Transform playerLoc;
	public LayerMask mask = 8;



	void Start()
	{
		playerLoc = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}


	// Update is called once per frame
	void Update () {
	
	//	transform.Rotate (Vector3.forward * rotSpeed, Time.deltaTime);
		// Vector 3.forward is manipulating the Z axis.

		Debug.DrawLine (enemySightStart.position, enemySightEnd.position, Color.red);  		
		// Raycast line. Only appears in scene mode

		isSpotted = Physics2D.Linecast (enemySightStart.position, enemySightEnd.position);
		//isSpotted = Physics2D.LineCast(enemySightStart.position, enemySightEnd.position, mask.value);


		if(isSpotted)
		{
			transform.position = Vector2.MoveTowards (transform.position, playerLoc.position, moveSpeed * Time.deltaTime);
		}


	}



}
using UnityEngine;
using System.Collections;

public class FPSController : MonoBehaviour {

	public float speed = 2f;
	float moveFrontBack;
	float moveLeftRight;
	CharacterController player;

	// Use this for initialization
	void Start () {
	
		player = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {


		moveFrontBack = Input.GetAxis ("Vertical") * speed;
		moveLeftRight = Input.GetAxis ("Horizontal") * speed;


		Vector3 movement = new Vector3 (moveLeftRight,moveFrontBack,0); // 0 is jump. LR is X, FB is Y, X,Y,Z
		movement = transform.rotation * movement; 
		player.Move (movement * Time.deltaTime);

	
	}
}

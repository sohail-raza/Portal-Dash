using UnityEngine;
using System.Collections;

public class ProjectileMove : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed;
	public Transform playerLoc;
	public Vector3 bulletDest;

	void Start () {
	

		playerLoc = GameObject.FindGameObjectWithTag ("Player").transform;
		bulletDest = new Vector2(playerLoc.position.x, playerLoc.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, bulletDest, moveSpeed * Time.deltaTime);
	}
}

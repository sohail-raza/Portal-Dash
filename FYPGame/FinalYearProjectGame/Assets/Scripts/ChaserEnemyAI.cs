using UnityEngine;
using System.Collections;

public class ChaserEnemyAI : MonoBehaviour {

	public float moveSpeed;
	private Transform playerLoc;


	// Use this for initialization
	void Start () {
		playerLoc = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, playerLoc.position, moveSpeed * Time.deltaTime);
	}
}

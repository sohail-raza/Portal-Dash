using UnityEngine;
using System.Collections;

public class ShootAI : MonoBehaviour {

	// Use this for initialization


	public GameObject proj;
	public float timeBetweenShots;
	public float startTimeBetween;


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


		if(timeBetweenShots <= 0) {
			Instantiate (proj, transform.position, Quaternion.identity);
				timeBetweenShots = startTimeBetween;

		}
			else {
				timeBetweenShots -= Time.deltaTime;
		}
	}
}
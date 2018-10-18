using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {


	void Start () {

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Knight" || col.gameObject.tag == "SpikeTrap" || col.gameObject.tag == "ElecFence" || col.gameObject.tag == "Projectile" ) {
			print ("collided");
			Destroy (this.gameObject); // Destroy Player

		

	
			}

		}
	}

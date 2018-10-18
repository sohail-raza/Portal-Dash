using UnityEngine;
using System.Collections;

public class interactionObject : MonoBehaviour {

	// Use this for initialization
	public bool inventory;
	public bool openable;
	public bool locked;
	public GameObject itemNeeded; 

	public void DoInteraction()
	{
		gameObject.SetActive(false);
	}
}
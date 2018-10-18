using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {


	public GameObject[] inventory = new GameObject[10]; //hold 10 items
	// Use this for initialization

	public void AddItem(GameObject item)
	{
		// Find first open slot
		bool itemAdded = false;
		for (int i = 0; i < inventory.Length; i++) {
			if (inventory [i] == null) {
				inventory [i] = item;
				Debug.Log (item.name + " was added");
				itemAdded = true;
				break;
			}
			// full inv
			if (!itemAdded) {
				Debug.Log ("Inventory full");


			}

		}



	}
	public bool FindItem(GameObject item)
	{
		for (int i = 0; i < inventory.Length; i++) {
			if (inventory [i] == item) {
				//found item
				return true;
		}

	}
	return false;



	}


}

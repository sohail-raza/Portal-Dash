using UnityEngine;
using System.Collections;

public class playerInteract : MonoBehaviour {

	public GameObject currentInteractableObject = null;
	public interactionObject currentInteractionObjScript;
	public Inventory inventory;



	void Update()
	{
		if (Input.GetButtonDown ("Interact") && currentInteractableObject) {
			if (currentInteractionObjScript.inventory) { //if inventory is true {
				inventory.AddItem(currentInteractableObject);
				currentInteractableObject.SendMessage ("DoInteraction");


			}

			//Can object be opened?

			if (currentInteractionObjScript.openable) {	//is the door locked?
					if (currentInteractionObjScript.locked) {
							if (inventory.FindItem(currentInteractionObjScript.itemNeeded)) {
									//found item
						currentInteractionObjScript.locked = false;
						Debug.Log (currentInteractableObject.name + " was unlocked");
						currentInteractableObject.SendMessage ("DoInteraction");


					} else {
						Debug.Log (currentInteractionObjScript.name + " was not unlocked");
					}

				} else {

					//object is not locked. Open it
					Debug.Log(currentInteractableObject.name + "is opened");

				}

			}
				
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("interactableObject")) {
			Debug.Log (other.name); //Check if walking into an object triggers debug code in console
			currentInteractableObject = other.gameObject;
			currentInteractionObjScript = currentInteractableObject.GetComponent<interactionObject>();


		}
			
		
	}
	
	void onTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("interactableObject")) {
			if (other.gameObject == currentInteractableObject) {
				
				currentInteractableObject = null;
			}

		}


	}
}

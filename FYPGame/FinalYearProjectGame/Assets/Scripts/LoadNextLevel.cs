using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour {



	private bool playerZone;
	public string levelLoad;
	public int currLevel;
	public int restartCounter;


	void Start () {
		playerZone = false;
		currLevel = SceneManager.GetActiveScene ().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && playerZone || Input.GetKeyDown("joystick button 3") && playerZone)

			 {
			SceneManager.LoadScene (levelLoad);
		}
	
		if (Input.GetKeyDown (KeyCode.R) || Input.GetKeyDown("joystick button 2")) {
			SceneManager.LoadScene (currLevel);
			restartCounter++;

		}

	}



	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.name == "Player") {

			playerZone = true;
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name == "Player") {
			playerZone = false;
		}
	}
}

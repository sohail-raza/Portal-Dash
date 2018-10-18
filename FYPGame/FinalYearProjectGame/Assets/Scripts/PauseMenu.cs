using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {


	public string lvlSelect;
	public string mainMenu;
	public bool isPaused;
	public GameObject pauseMenu;


	// Update is called once per frame
	void Update () {
	
		if (isPaused) {

			pauseMenu.SetActive(true);
			// if game is paused
		}
		else 
		{
			pauseMenu.SetActive (false);
		}
		

		if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
			{

				isPaused = !isPaused;
			}


	}

	public void Resume()
	{


	}
	public void Restart()
	{



	}
	public void LevelSelect()
	{
		Application.LoadLevel (lvlSelect);

	}
	public void Quit()
	{

		Application.LoadLevel (mainMenu);

	}
			}

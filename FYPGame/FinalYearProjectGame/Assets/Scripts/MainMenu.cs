using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	public string startLvl;
	public string lvlSelect;



	public void NewGame()
	{

		SceneManager.LoadScene(startLvl);

	}
	public void LvlSelect ()
	{

		Application.LoadLevel (lvlSelect);


	}
	public void QuitGame()
	{

		Application.Quit();



	}


}



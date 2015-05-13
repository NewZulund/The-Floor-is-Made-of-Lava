using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseManagerScript : MonoBehaviour {

	public GameObject pauseMenu;

	public void PauseGame(){
		pauseMenu.SetActive(true);
		Time.timeScale = 0;
	}

	public void ContinueGame(){
		pauseMenu.SetActive (false);
		Time.timeScale = 1;
	}

	public void RestartGame(){
		Application.LoadLevel ("EndlessRunning");
		Time.timeScale = 1;
	}

	public void QuitGame(){
		Application.LoadLevel ("Home");
		Time.timeScale = 1;
	}

}

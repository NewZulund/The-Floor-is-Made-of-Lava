using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseManagerScript : MonoBehaviour {

	public GameObject pauseMenu;
	public GameObject backgroundMask;

	public void PauseGame(){
		pauseMenu.SetActive(true);
		backgroundMask.SetActive (true);
		Time.timeScale = 0;
	}

	public void ContinueGame(){
		pauseMenu.SetActive (false);
		resume ();
	}

	public void RestartGame(){
		Application.LoadLevel ("EndlessRunning");
		resume ();
	}

	public void QuitGame(){
		Application.LoadLevel ("Home");
		resume ();
	}

	private void resume(){
		backgroundMask.SetActive (false);
		Time.timeScale = 1;
	}

}

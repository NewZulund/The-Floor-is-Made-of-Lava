using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseManagerScript : MonoBehaviour {

	public GameObject pauseMenu;
	public GameObject backgroundMask;//The mask that greys out the background
	public GameObject countdown;//A ui text object that is used as a countdown

	private float targetTime = 0;//used for countdown after continuing from the pause menu

	void Update(){
		float time = targetTime - Time.realtimeSinceStartup;
		string txt = time.ToString ("0");
		if (txt.Equals ("0")) {
			txt = "Go!";
		}
		countdown.GetComponent<Text> ().text = txt;
	}

	public void PauseGame(){
		pauseMenu.SetActive(true);
		backgroundMask.SetActive (true);
		Time.timeScale = 0;
	}

	public void ContinueGame(){
		StartCoroutine ("Continue");
	}

	IEnumerator Continue(){
		pauseMenu.SetActive (false);
		countdown.SetActive (true);
		targetTime = Time.realtimeSinceStartup + 3.5f;

		yield return StartCoroutine (CoroutineUtil.WaitForRealSeconds (3));

		resume ();

		yield return new WaitForSeconds (1);
		countdown.SetActive (false);
	}

	public static class CoroutineUtil{
		public static IEnumerator WaitForRealSeconds(float time){
			float start = Time.realtimeSinceStartup;
			while(Time.realtimeSinceStartup < start+time){
				yield return null;
			}
		}
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

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseManagerScript : MonoBehaviour {

	public GameObject pauseMenu;
	public GameObject gameOverMenu;
	public GameObject backgroundMask;//The mask that greys out the background
	public GameObject countdown;//A ui text object that is used as a countdown
	public GameObject gameController;
	public Text gameOverScore;

	private float targetTime = 0;//used for countdown after continuing from the pause menu
	private bool countingDown;

	void Awake(){
		Time.timeScale = 1;
	}

	void Update(){
		float time = targetTime - Time.realtimeSinceStartup;
		if (countingDown) {
			string txt = time.ToString ("0");
			if (txt.Equals ("0")) {
				txt = "Go!";
			}
			countdown.GetComponent<Text> ().text = txt;

			if(time<0){
				countingDown = false;//stopped counting down
			}
		}
	}

	public void PauseGame(){
		countdown.SetActive (false);//prevent the countdown text from showing when you pause the game whiole the word "Go!" is shown. Another idea could be to simply put the countdown text behind the pausemenu in the gui hierachy
		pauseMenu.SetActive(true);
		backgroundMask.SetActive (true);
		Time.timeScale = 0;
	}

	public void ContinueGame(){
		StartCoroutine ("Continue");
	}


	public void RestartGame(){
		Application.LoadLevel ("EndlessRunning");
		Resume ();
	}

	public void QuitGame(){
		Application.LoadLevel ("Home");
		Resume ();
	}
	

	public void GameOver(){
		Time.timeScale = 0;
		int score = (int) gameController.GetComponent<EndlessController> ().score;
		gameOverMenu.SetActive(true);
		backgroundMask.SetActive (true);
		gameOverScore.text = string.Format("(0:n0)", score);//score.ToString("0");
	}

	private void Resume(){
		backgroundMask.SetActive (false);
		Time.timeScale = 1;
	}

	IEnumerator Continue(){
		pauseMenu.SetActive (false);
		countdown.SetActive (true);
		countingDown = true;//we've started the countdown
		targetTime = Time.realtimeSinceStartup + 3.5f;//add .5 seconds to take into account lag
		
		yield return StartCoroutine (CoroutineUtil.WaitForRealSeconds (3));
		
		Resume ();
		
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

}

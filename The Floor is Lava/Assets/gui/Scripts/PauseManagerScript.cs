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
	public Text highscoreText;
	public GameObject highscoresDialog;
	public GameObject highscoreEntryPrefab;
	public GameObject highscoresPanel;


	private float targetTime = 0;//used for countdown after continuing from the pause menu
	private bool countingDown;
	private string highscoreKey = "highscore";//key used when accessing 'highscore' value in PlayerPrefs

	void Awake(){
		//GetHighscoresPanel ();
		CloseHighscores ();

		//PlayerPrefs.DeleteAll ();

		//Countdown at the beginning of the game
		//PauseGame ();//use pauseGame instead if we want the mask at the beginning//Time.timeScale = 0;
		Time.timeScale = 1;
		backgroundMask.SetActive (true);
		StartCoroutine ("Continue");
	}

	private void GetHighscoresPanel(){
		foreach (Transform child in highscoresDialog.transform) {
			if(child.gameObject.tag.Equals("HighscoresPanel")){
				highscoresPanel = child.gameObject;
				return;
			}
		}
		print ("ERROR: Cannot Find Highscores Panel");
	}

	void Update(){
		float time = targetTime - Time.realtimeSinceStartup;
		if (countingDown) {
			EndlessController.controller.score = 0;
			string txt = time.ToString ("0");
			if (txt.Equals ("0")) {
				txt = "R u n !";
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
		//backgroundMask.SetActive (true);
		Time.timeScale = 0;
	}

	public void ContinueGame(){
		backgroundMask.SetActive (true);
		StartCoroutine ("Continue");
	}


	public void RestartGame(){
		Application.LoadLevel (1);
		Resume ();
	}

	public void QuitGame(){
		Application.LoadLevel (0);
		Resume ();
	}
	

	public void GameOver(){
		print ("called gameover");
		Time.timeScale = 0;
		int score = (int) gameController.GetComponent<EndlessController> ().score;
		gameOverMenu.SetActive(true);
		//backgroundMask.SetActive (true);
		gameOverScore.text = string.Format("{0:n0}", score);//score.ToString("0");
		SetHighscore (score);
		highscoreText.text = string.Format ("{0:n0}", PlayerPrefs.GetInt (highscoreKey+0));
	}

	private void SetHighscore(int highscore){
		print ("called set highscore");
		for(int i = 0; i<10; i++){

			string key = highscoreKey + i;
			string stringKey = key+"string";

			if (PlayerPrefs.HasKey (key)) {
				if (PlayerPrefs.GetInt (key) <= highscore) {

					//move every following score down
					int currentScore = highscore;
					string currentDate = System.DateTime.Now.ToString("dd/MM/yy");

					int nextScore = PlayerPrefs.GetInt(key);
					string nextDate = PlayerPrefs.GetString(stringKey);

					PlayerPrefs.SetInt (key, currentScore);
					PlayerPrefs.SetString (stringKey, currentDate);

					i++;
					key = highscoreKey+i;
					stringKey = key+"string";

					while(i<10 && PlayerPrefs.HasKey(key)){

						currentScore = nextScore;
						currentDate = nextDate;

						nextScore = PlayerPrefs.GetInt(key);
						nextDate = PlayerPrefs.GetString (stringKey);

						PlayerPrefs.SetInt (key, currentScore);
						PlayerPrefs.SetString (stringKey, currentDate);

						i++;
						key = highscoreKey+i;
						stringKey = key+"string";
					}

					if(i<10 && !PlayerPrefs.HasKey (key)){
						PlayerPrefs.SetInt (key, nextScore);
						PlayerPrefs.SetString (stringKey, nextDate);
					}

					return;
				}
			} else {
				PlayerPrefs.SetInt (key, highscore);
				PlayerPrefs.SetString (stringKey, System.DateTime.Now.ToString("dd/MM/yy"));
				return;
			}

		}
	}


	public void ShowHighscores(){
		for (int i = 0; i<10; i++) {
			string key = highscoreKey + i;
			string stringKey = key+"string";

			GameObject newChild = Instantiate (highscoreEntryPrefab);
			newChild.transform.SetParent(highscoresPanel.transform, false);

			if (PlayerPrefs.HasKey (key)) {
				foreach (Transform child in newChild.transform) {
					if (child.gameObject.tag.Equals ("HighscoreNumber")) {
						child.gameObject.GetComponent<Text>().text = (i+1).ToString("0");
					} else if (child.gameObject.tag.Equals ("HighscoreScore")) {
						child.gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt(key).ToString("0");
					} else if (child.gameObject.tag.Equals ("HighscoreDate")) {
						child.gameObject.GetComponent<Text>().text = PlayerPrefs.GetString(stringKey);
					}
				}
			} else {
				foreach (Transform child in newChild.transform) {
					if (child.gameObject.tag.Equals ("HighscoreNumber")) {
						child.gameObject.GetComponent<Text>().text = (i+1).ToString("0");
					}
				}
			}

		}

		highscoresDialog.SetActive (true);
	}

	public void CloseHighscores(){
		highscoresDialog.SetActive (false);

		foreach (Transform child in highscoresPanel.transform) {
			Destroy (child.gameObject);
		}
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

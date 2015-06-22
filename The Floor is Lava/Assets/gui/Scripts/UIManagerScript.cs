using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	public Text homeScreenText;

	public void StartGame(){
		homeScreenText.text = "Loading...";

		Application.LoadLevel (1);
	}
}

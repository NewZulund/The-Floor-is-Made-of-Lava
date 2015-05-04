using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndlessController : MonoBehaviour {

	public static EndlessController controller;
	public float runSpeed = 15.0f;
	public float currentRunSpeed = 15.0f;
	public Text scoreText;

	public float score;
	public float earnRate = 1;

	public float speedIncreaseRate = 0.2f;
	public Text speedText;

	void Awake () 
	{
		if(controller != null)
		{
			Destroy(this.gameObject);
		}
		else
		{
			Debug.Log("Controller Established");
			controller = this;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//TODO acceleration/deceleration
		if(currentRunSpeed < runSpeed)
		{
			currentRunSpeed += currentRunSpeed * speedIncreaseRate * Time.deltaTime;
		}
		score += currentRunSpeed * earnRate * Time.deltaTime; 
		scoreText.text = score.ToString("0");

		speedText.text = currentRunSpeed.ToString("0");
	}

	public void SlowPlayer(float percentageDecrease)
	{
		currentRunSpeed -= currentRunSpeed * percentageDecrease;
	}

}

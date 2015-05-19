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

	void Awake () 
	{
		if(controller != null)
		{
			Destroy(this.gameObject);
		}
		else
		{
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
		scoreText.text = string.Format ("{0:n0}", score);//'n' formats the number to have a comma after every three digits. 0 tells it not to have decimal numbers

	}

	public void SlowPlayer(float percentageDecrease)
	{
		currentRunSpeed -= currentRunSpeed * percentageDecrease;
	}

	public void PickUp (Collectable collectable)
	{
		if(collectable.type == Collectable.CollectableType.Coin)
		{
			//TODO add some UI element here. 
			score += collectable.value;
		}
	}
}

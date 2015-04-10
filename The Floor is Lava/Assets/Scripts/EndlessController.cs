using UnityEngine;
using System.Collections;

public class EndlessController : MonoBehaviour {

	public static EndlessController controller;
	public float runSpeed = 3.0f;

	public float currentRunSpeed{ get; private set; }
	
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
		currentRunSpeed = runSpeed;
	}
}

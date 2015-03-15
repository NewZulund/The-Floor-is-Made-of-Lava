using UnityEngine;
using System.Collections;

public class EndlessPropMover : MonoBehaviour {

	EndlessController controller; 
	// Use this for initialization
	void Start () {
		controller = EndlessController.controller;

		if(!controller)
		{
			Debug.Log("No controller in EndlessPropMover!");
		}
	}

	void Update()
	{
		//Move object by run speed forward
		if(controller)
		{
			transform.position = transform.position + (Vector3.forward * controller.currentRunSpeed * Time.deltaTime);
		}
	}
}

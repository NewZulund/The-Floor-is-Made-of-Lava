using UnityEngine;
using System.Collections;

public class KeyboardControls : MonoBehaviour {

	public EndlessCharacterController controller;
	MonstarController monsterController;

	void Awake()
	{
		monsterController = EndlessController.controller.monstarController;
	}

	public static float DEADZONE_HORIZONTAL = 0.05f;
	public static float DEADZONE_VERTICAL = 0.005f;

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel(0);
		}


		float vertical = Input.GetAxis("Vertical");
		if(vertical > DEADZONE_VERTICAL)
		{
			controller.Jump();
		}
//		if (vertical < -DEADZONE_VERTICAL) {
//			controller.Slide();
//		}

		float horizontal = Input.GetAxis("Horizontal");
		if( horizontal > DEADZONE_HORIZONTAL)
		{
			controller.MoveRight();
		}
		else if(horizontal < -DEADZONE_HORIZONTAL)
		{
			controller.MoveLeft(); 
		}
	}
}

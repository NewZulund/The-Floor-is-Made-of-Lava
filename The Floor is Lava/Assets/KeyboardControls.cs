using UnityEngine;
using System.Collections;

public class KeyboardControls : MonoBehaviour {

	EndlessCharacterController controller;

	void Awake()
	{
		controller = GetComponent<EndlessCharacterController>();
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

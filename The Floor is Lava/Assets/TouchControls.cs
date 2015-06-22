using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

	//Controller variables
	public static float TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE = 0.015f;
	public static float TOUCH_DEADZONE_VERTICAL_PERCENTAGE = 0.25f;
	public static float TOUCH_VERTICAL_JUMP_LENGTH = 1.0f;
	public static float TOUCH_WIDTH_TOTAL_MOVEMENT_PERCENTAGE = 0.75f; //TODO Rename

	EndlessCharacterController controller;

	void Start()
	{
		controller = GetComponent<EndlessCharacterController>();
	}

	void Update()
	{
		int numTouch = Input.touchCount;
		
		if(numTouch > 0)
		{
			for (int i = 0; i < numTouch; i++)
			{
				Touch touch = Input.GetTouch(i);
				
				if(touch.deltaPosition.x / Screen.width  > TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE)
				{
					controller.MoveRight();
				}
				else if (touch.deltaPosition.x / Screen.width < -TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE)
				{
					controller.MoveLeft();
				} else if (touch.deltaPosition.y / (Screen.width * 0.1f) > TOUCH_DEADZONE_VERTICAL_PERCENTAGE)
				{
					controller.Jump();
				}
			}
		}
	}
}

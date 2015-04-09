using UnityEngine;
using System.Collections;

public enum PlayerMovementStatus {MovingLeft, NotMoving, MovingRight};

public class EndlessCharacterController : MonoBehaviour {

	//Horizontal Movement Variables
	public float moveSpeed = 0.5f;
	public float movementCounter = 0.0f;
	private Vector3 startMovePosition;
	public RunningRail currentRail; 
	private RunningRail targetRail;

	//Player Variables
	public PlayerMovementStatus movementStatus = PlayerMovementStatus.NotMoving;

	//Controller variables
	public static float DEADZONE_HORIZONTAL = 0.05f;
	public static float DEADZONE_VERTICAL = 0.1f;
	public static float TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE = 0.05f;
	public static float TOUCH_DEADZONE_VERTICAL_PERCENTAGE = 0.05f;
	public static float TOUCH_VERTICAL_JUMP_LENGTH = 1.0f;
	public static float TOUCH_WIDTH_TOTAL_MOVEMENT_PERCENTAGE = 0.75f; //TODO Rename

	//Jump Variables
	//TODO not use forces. 
	public float verticalForce = 5000.0f;
	public float jumpDelay = 1.0f; 
	public bool canJump;
	private float nextJumpTime;

	private Rigidbody rigidbody;

	void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		//TODO Raycast to check if the player can jump

		//Movement booleans
		bool moveRight = false;
		bool moveLeft = false;
		bool jump = false;

		//Check for touch input
		if(Input.touchCount > 0)
		{
			for(int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);

				if(touch.deltaPosition.y / Screen.height > TOUCH_DEADZONE_VERTICAL_PERCENTAGE)
				{
					jump = true;
				}

				if(touch.deltaPosition.x / Screen.width  > TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE)
				{
					moveRight = true; 
				}
				else if (touch.deltaPosition.x / Screen.width < -TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE)
				{
					moveLeft = true;
				}
			}
		}
		else // PC Keyboard or Controller Input
		{
			float vertical = Input.GetAxis("Vertical");
			if(vertical > DEADZONE_VERTICAL)
			{
				jump = true;
			}

			float horizontal = Input.GetAxis("Horizontal");
			if( horizontal > DEADZONE_HORIZONTAL)
			{
				moveRight = true;
			}
			else if(horizontal < -DEADZONE_HORIZONTAL)
			{
				moveLeft = true; 
			}
		}


		//Generate movemement target
		Vector3 targetPosition = currentRail.position;

		//If both or neither directions are activated. Do nothing
		if(moveLeft && !moveRight){
			//Swyped Left 
			if(movementStatus == PlayerMovementStatus.NotMoving)
			{
				//Start movememt
				targetRail = currentRail.leftRail;
				movementStatus = PlayerMovementStatus.MovingLeft;
				startMovePosition = transform.position;
				movementCounter = 0;
			}
		}
		else if(moveRight && !moveLeft){
			//Swyped Right
			if(movementStatus == PlayerMovementStatus.NotMoving)
			{
				//Start movement
				targetRail = currentRail.rightRail;
				movementStatus = PlayerMovementStatus.MovingRight;
				startMovePosition = transform.position;
				movementCounter = 0;
			}
		}

		if(targetRail != null){
			targetPosition = targetRail.transform.position;
		}
		else{
			CancelMovement();
		}


		//Apply movememnt
		if(movementStatus != PlayerMovementStatus.NotMoving)
		{
			//Ignore y/z movement
			targetPosition = new Vector3(targetPosition.x, transform.position.y, transform.position.z);
			transform.position = Vector3.Lerp(startMovePosition, targetPosition, movementCounter);
			movementCounter += Time.deltaTime / moveSpeed;
		}

		//Movement is complete. The player will be in the target position
		if(movementCounter >= 1)
		{
			movementStatus = PlayerMovementStatus.NotMoving;
			movementCounter = 0;
			currentRail = targetRail;
		}


		//TODO limit with raycast result
		if(jump){
			rigidbody.AddForce(Vector3.up * verticalForce);
		}
	}

	public void CancelMovement(){
		targetRail = currentRail;
		movementCounter = 0;
		movementStatus = PlayerMovementStatus.NotMoving;
	}
}
 
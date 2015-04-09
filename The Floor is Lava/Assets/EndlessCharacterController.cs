using UnityEngine;
using System.Collections;

public enum PlayerPosition{Left,Center,Right};
public enum PlayerMovementStatus {MovingLeft, NotMoving, MovingRight};

public class EndlessCharacterController : MonoBehaviour {
	
	public PlayerPosition position = PlayerPosition.Center;
	public PlayerMovementStatus movementStatus = PlayerMovementStatus.NotMoving;
	private Vector3 startMovePosition;

	//Movement Variables
	public float verticalForce = 5000.0f;

	//TODO replace with rails
	public float maxMovement_Horizontal = 3.0f;


	//Controller variables
	public static float DEADZONE_HORIZONTAL = 0.05f;
	public static float DEADZONE_VERTICAL = 0.1f;

	public static float TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE = 0.05f;
	public static float TOUCH_DEADZONE_VERTICAL_PERCENTAGE = 0.05f;

	public static float TOUCH_VERTICAL_JUMP_LENGTH = 1.0f;
	public static float TOUCH_WIDTH_TOTAL_MOVEMENT_PERCENTAGE = 0.75f; //TODO Rename

	public static float RUNNING_DISTANCE_FROM_CENTER = 2.5f;

	public float sideRunningTime = 1.0f;
	public float moveSpeed = 0.5f;
	public float movementCounter = 0.0f;
	public float movementInitialX = 0.0f;

	public bool canJump = true;
	public float jumpDelay = 1.0f; 
	private float nextJumpTime;

	private Rigidbody rigidbody;

	void Awake(){
		rigidbody = GetComponent<Rigidbody>();
	}

	void Update () 
	{

		if(!canJump && Time.time > nextJumpTime)
		{
			canJump = true;
		}

		//Check for touch input
		if(Input.touchCount > 0)
		{
			for(int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);

				if(canJump)
				{
					if(touch.deltaPosition.y / Screen.height > TOUCH_DEADZONE_VERTICAL_PERCENTAGE)
					{
						rigidbody.AddForce(new Vector3(0.0f,verticalForce,0.0f), ForceMode.Impulse);
						nextJumpTime = Time.time + jumpDelay;
						canJump = false;
					}
				}

				if(touch.deltaPosition.x / Screen.width  > TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE)
				{
					if(position != PlayerPosition.Right && movementStatus == PlayerMovementStatus.NotMoving)//Can move left
					{
						movementStatus = PlayerMovementStatus.MovingRight;
						startMovePosition = transform.position;
					}
				}
				else if (touch.deltaPosition.x / Screen.width < -TOUCH_DEADZONE_HORIZONTAL_PERCENTAGE)
				{
					if(position != PlayerPosition.Left && movementStatus == PlayerMovementStatus.NotMoving)
					{
						movementStatus = PlayerMovementStatus.MovingLeft;
						startMovePosition = transform.position;
					}
				}
			}
		}
		else // PC Keyboard or Controller Input
		{
			if(canJump)
			{
				float vertical = Input.GetAxis("Vertical");
				if(vertical > DEADZONE_VERTICAL || vertical < -DEADZONE_VERTICAL)
				{
					Debug.Log("Jumping " + Time.time);
					rigidbody.AddForce(new Vector3(0.0f,verticalForce,0.0f),ForceMode.Impulse);
					nextJumpTime = Time.time + jumpDelay;
					canJump = false;
				}
			}

			float horizontal = Input.GetAxis("Horizontal");
			if( horizontal > DEADZONE_HORIZONTAL)
			{
				if(position != PlayerPosition.Right && movementStatus == PlayerMovementStatus.NotMoving)//Can move left
				{
					movementStatus = PlayerMovementStatus.MovingRight;
					startMovePosition = transform.position;
				}
			}
			else if(horizontal < -DEADZONE_HORIZONTAL)
			{
				if(position != PlayerPosition.Left && movementStatus == PlayerMovementStatus.NotMoving)
				{
					movementStatus = PlayerMovementStatus.MovingLeft;
					startMovePosition = transform.position;
				}
			}
		}

		if(movementStatus != PlayerMovementStatus.NotMoving && movementCounter <= 1){
			
			float goalX = 0.0f; 
			
			if(movementStatus == PlayerMovementStatus.MovingLeft)
			{
				if(position == PlayerPosition.Center)
				{
					goalX = -RUNNING_DISTANCE_FROM_CENTER;
				}
				else if (position == PlayerPosition.Right)
				{
					goalX = 0.0f;
				}
				else
				{
					movementStatus = PlayerMovementStatus.NotMoving;
				}
			}
			else if(movementStatus == PlayerMovementStatus.MovingRight)
			{
				if(position == PlayerPosition.Center)
				{
					goalX = RUNNING_DISTANCE_FROM_CENTER;
				}
				else if (position == PlayerPosition.Left)
				{
					goalX = 0.0f; 
				}
				else
				{
					movementStatus = PlayerMovementStatus.NotMoving;
				}
			}

			Vector3 finalPosition = new Vector3(goalX, transform.position.y, transform.position.z);
			transform.position = Vector3.Lerp(startMovePosition, finalPosition, movementCounter);
			movementCounter += Time.deltaTime / moveSpeed;
		}

		if (movementCounter >= 1.0f)
		{
			//TODO build helper method for these ifs
			if(movementStatus == PlayerMovementStatus.MovingLeft)
			{
				if(position == PlayerPosition.Center)
				{
					position = PlayerPosition.Left;
				}
				else
				{
					position = PlayerPosition.Center;
				}
			}
			else if (movementStatus == PlayerMovementStatus.MovingRight)
			{
				if(position == PlayerPosition.Center)
				{
					position = PlayerPosition.Right;
				}
				else
				{
					position = PlayerPosition.Center;
				}
			}

			movementStatus = PlayerMovementStatus.NotMoving;
			movementCounter = 0.0f;
		}
	}
	
	void recenterPlayer ()
	{
		if(transform.position.x <= 0.1f || transform.position.x >= -0.1f){
			Vector3 targetPosition = new Vector3(0.0f, transform.position.y, transform.position.z);
			transform.position = Vector3.Lerp(transform.position, targetPosition, movementCounter);
			movementCounter = targetPosition.x - transform.position.x;
		}
	}
}
 
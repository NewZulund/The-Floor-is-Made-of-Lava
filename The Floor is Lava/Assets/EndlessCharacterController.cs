using UnityEngine;
using System.Collections;

public class EndlessCharacterController : MonoBehaviour {

	public enum PlayerPosition{	Left,Center,Right};
	public enum PlayerMovementStatus {MovingLeft, NotMoving, MovingRight};

	public PlayerPosition position = playerPosition.Center;
	public PlayerMovementStatus movementStatus = playerMovementStatus.NotMoving;

	public float verticalForce = 5000.0f;

	public float maxMovement_Horizontal = 3.0f;

	public static float DEADZONE_HORIZONTAL = 0.05f;
	public static float DEADZONE_VERTICAL = 0.1f;

	public static float TOUCH_DEADZONE_HORIZONTAL = 1.0f;
	public static float TOUCH_DEADZONE_VERTICAL_PERCENTAGE = 0.1f;

	public static float TOUCH_VERTICAL_JUMP_LENGTH = 1.0f;
	public static float TOUCH_WIDTH_TOTAL_MOVEMENT_PERCENTAGE = 0.75f; //TODO Rename

	public static float RUNNING_DISTANCE_FROM_CENTER = 2.5f;
	public float sideRunningTime = 1.0f;
	public float movementTime = 0.5f;
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
		if(movingLeft || movingRight)
		{
			movePlayer();
		}
		else
		{
			recenterPlayer();
		}

		if(!canJump && Time.time > nextJumpTime)
		{
			canJump = true;
		}

		Vector3 oldPosition = transform.position;
		float positionX = transform.position.x;
		float positionY = transform.position.y;

		//Check for touch input
		if(Input.touchCount > 0)
		{
			for(int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);

				if(canJump)
				{
					if(Mathf.Abs(touch.deltaPosition.y / Screen.height) > TOUCH_DEADZONE_VERTICAL_PERCENTAGE)
					{
						//rigidbody.AddForce(new Vector3(0.0f,verticalForce,0.0f));
						nextJumpTime = Time.time + jumpDelay;
						canJump = false;
					}
				}

				if(touch.deltaPosition.x > TOUCH_DEADZONE_HORIZONTAL)
				{
					if(position != PlayerPosition.Left && movementStatus == PlayerMovementStatus.NotMoving)//Can move left
					{
						movementStatus = PlayerMovementStatus.MovingLeft;
					}
				}
				else if (touch.deltaPosition.x < -TOUCH_DEADZONE_HORIZONTAL)
				{
					if(position != PlayerPosition.Right && movementStatus == PlayerMovementStatus.NotMoving)
					{
						movementStatus = PlayerMovementStatus.MovingRight;
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
					//rigidbody.AddForce(new Vector3(0.0f,verticalForce,0.0f));
					nextJumpTime = Time.time + jumpDelay;
					canJump = false;
				}
			}

			float horizontal = Input.GetAxis("Horizontal");
			if( horizontal > DEADZONE_HORIZONTAL)
			{
				if(position != PlayerPosition.Left && movementStatus == PlayerMovementStatus.NotMoving)//Can move left
				{
					movementStatus = PlayerMovementStatus.MovingLeft;
				}
			}
			else if(horizontal < -DEADZONE_HORIZONTAL)
			{
				if(position != PlayerPosition.Right && movementStatus == PlayerMovementStatus.NotMoving)
				{
					movementStatus = PlayerMovementStatus.MovingRight;
				}
			}

		}

		movePlayer();

		//Apply movement
		//transform.position = new Vector3(positionX, positionY, transform.position.z);
	}

	void movePlayer ()
	{



		float targetX = movingLeft ? -RUNNING_DISTANCE_FROM_CENTER : RUNNING_DISTANCE_FROM_CENTER; 
		float counter = movingLeft ? moveLeftT : moveRightT;
		
		Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, targetPosition, counter);

		if (counter >= 1){
			movingLeft = false;
			movingRight = false;
			return;
		}

		if(movingLeft)
		{
			moveLeftT += movementTime * Time.deltaTime;
		}
		else
		{
			moveRightT += movementTime * Time.deltaTime;
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
 
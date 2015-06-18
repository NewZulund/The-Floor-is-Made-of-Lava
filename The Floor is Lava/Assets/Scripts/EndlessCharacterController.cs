using UnityEngine;
using System.Collections;

public enum PlayerMovementStatus {MovingLeft, NotMoving, MovingRight};

public class EndlessCharacterController : MonoBehaviour {

	//Horizontal Movement Variables
	public RunningRail currentRail; 
	private RunningRail targetRail;
	public float moveSpeed = 0.5f;
	public float movementCounter = 0.0f;
	private float startMoveX;
	public float xPosition; 

	//Vertical Movement Variables
	public float fallVelocity = -9.8f;
	public float jumpVelocity = 300.0f;
	public float yVelocity = 0.0f;
	public bool isJumping = false;
	public float jumpRaycastLength = 1.0f;
	public float distanceToGround = 0.0f;
	public float lavaHitYVelocity = 40.0f;

	//Oncoming hit 
	public float frontHitDistance = 1.0f;
	public float frontHitVelocity = 10.0f;

	//Sound
	public AudioSource audio;
	public AudioClip lavaburn;
	public AudioClip jump;
	public AudioListener audioListener;

	public bool musicActive = true;
	
	public PlayerMovementStatus movementStatus = PlayerMovementStatus.NotMoving;
	public Animator animator;

	void Start()
	{
		distanceToGround = GetComponent<CapsuleCollider>().bounds.extents.y;
	}

	void Update () 
	{

		//Calculate Horiztonal Movement
		if(movementCounter != 0 || movementStatus != PlayerMovementStatus.NotMoving)
		{
			float targetPosition = currentRail.position.x;
			
			if(targetRail != null){
				targetPosition = targetRail.transform.position.x;
			}
			else{
				CancelMovement();
			}

			xPosition = Mathf.Lerp(startMoveX, targetPosition, movementCounter);
			movementCounter += Time.deltaTime / moveSpeed;

			if(movementCounter >= 1)
			{
				movementStatus = PlayerMovementStatus.NotMoving;
				movementCounter = 0;
				currentRail = targetRail;
			}

		}

		//Calculate Vertical Movement
		if(!isGrounded())
		{
			yVelocity += fallVelocity * Time.deltaTime;
		}
		else
		{
			//Bounce off lava if grounded on lava
			if(IsGroundedLava() )
			{
				//Don't stack the velocity increases if it is already positive. 
				if(yVelocity <= 0)
				{
					yVelocity = lavaHitYVelocity;
					EndlessController.controller.SlowPlayer(0.4f);
					audio.PlayOneShot(lavaburn);
				}
			}
			else
			{
				yVelocity = 0;
				AdjustStandingHeight(); 
			}

			if(isJumping && isGrounded ())
			{
				animator.SetBool("IsJumping", false);
				isJumping = false;
			}

		}

		//Override vertical if the player is going to hit something
		if(FrontHit())
		{
			if(yVelocity <= 0)
			{
				yVelocity = frontHitVelocity;
			}
		}

		//Apply movememnt
		float xMovement = xPosition - transform.position.x;
		transform.Translate(xMovement, yVelocity * Time.deltaTime,0);

	}

	public void MoveLeft()
	{
		if(movementStatus == PlayerMovementStatus.NotMoving)
		{
			//Start movememt
			targetRail = currentRail.leftRail;
			movementStatus = PlayerMovementStatus.MovingLeft;
			startMoveX = xPosition;
			movementCounter = 0;
		}
		CheckFail ();
	}

	public void MoveRight()
	{
		if(movementStatus == PlayerMovementStatus.NotMoving)
		{
			//Start movement
			targetRail = currentRail.rightRail;
			movementStatus = PlayerMovementStatus.MovingRight;
			startMoveX = xPosition;
			movementCounter = 0;
		}
		CheckFail ();
	}

	public void Jump()
	{
		if(isGrounded() && !isJumping)
		{
			yVelocity = jumpVelocity;
			animator.SetBool("IsJumping", true);
			isJumping = true;
			audio.PlayOneShot(jump);
			StartCoroutine (Pause());
		}
	}

	IEnumerator Pause(){
		yield return new WaitForSeconds (0.1f);
	}

	public void CheckFail (){
		if (!isGrounded ()) {
			yVelocity += fallVelocity * Time.deltaTime;
		}
	}

	public void CancelMovement(){
		targetRail = currentRail;
		movementCounter = 0;
		movementStatus = PlayerMovementStatus.NotMoving;
	}
	
	public void PlayerSideHit ()
	{
		targetRail = currentRail;
		movementCounter = 0;
		startMoveX = xPosition;

		if(movementStatus == PlayerMovementStatus.MovingLeft)
		{
			movementStatus = PlayerMovementStatus.MovingRight;
		}
		else
		{
			movementStatus = PlayerMovementStatus.MovingLeft;
		}
	}

	public bool isGrounded()
	{
		return Physics.Raycast(transform.position, Vector3.down, distanceToGround + 0.1f);
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(transform.position, transform.position + Vector3.down * distanceToGround);
		Gizmos.DrawLine(transform.position + (-transform.up * distanceToGround * 0.80f), transform.position + (-transform.up * distanceToGround * 0.80f) + -Vector3.forward * frontHitDistance);
	}

	bool IsGroundedLava ()
	{
		RaycastHit hit;
		if(Physics.Raycast(transform.position, Vector3.down, out hit, distanceToGround + 0.1f)){
			//Debug.Log(hit.transform.tag);
			if(hit.transform.tag == "Lava" || hit.transform.tag == "LavaCollider")
			{
				return true;
			}
		}
		return false; 
	}

	bool FrontHit()
	{
		return (Physics.Raycast(transform.position + (-transform.up * distanceToGround * 0.80f), -transform.forward, frontHitDistance));
	}

	void AdjustStandingHeight ()
	{
		RaycastHit hit;
		if(Physics.Raycast(transform.position, Vector3.down, out hit, distanceToGround + 0.1f)){
			if(hit.transform.tag != "Lava" && hit.transform.tag != "LavaCollider")
			{
				transform.Translate(transform.position.x + distanceToGround - hit.distance ,0,0);
			}
		}
	}
}
 
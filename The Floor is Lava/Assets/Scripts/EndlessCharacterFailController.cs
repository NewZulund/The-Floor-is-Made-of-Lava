using UnityEngine;
using System.Collections;

public class EndlessCharacterFailController : MonoBehaviour {

	public GameObject happyMouth;
	public GameObject sadMouth;
	public GameObject fireEffects;
	public Rigidbody rigidBody;

	//Lava hit variables
	public float hurtBounceSpeed = 10.0f;
	public float hurtModelRevertTime = 1.0f;

	private EndlessController controller;

	void Awake()
	{
		controller = GameObject.Find ("EndlessController").GetComponent<EndlessController> ();
		sadMouth.SetActive(false);
		happyMouth.SetActive(true);
		rigidBody =  GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "LavaCollider")
		{
			controller.SlowPlayer(0.4f);
			happyMouth.SetActive(false);
			sadMouth.SetActive(true);
			rigidBody.velocity = Vector3.up * hurtBounceSpeed;
			//Flip hurt model back
			Invoke("RevertHurtModel", hurtModelRevertTime);
		}
	}

	void RevertHurtModel()
	{
		sadMouth.SetActive(false);
		happyMouth.SetActive(true);
	}
}

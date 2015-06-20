using UnityEngine;
using System.Collections;

public class EndlessCharacterFailController : MonoBehaviour {

	public GameObject fireEffects;
	public Rigidbody rigidBody;
	private EndlessController controller;
	EndlessCharacterController characterController;

	void Awake()
	{
		controller = EndlessController.controller;
		characterController = GetComponent<EndlessCharacterController>();
		rigidBody =  GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision collision)
	{
//		if(collision.gameObject.tag == "LavaCollider")
//		{
//			controller.SlowPlayer(0.4f);
//		}
	}
}

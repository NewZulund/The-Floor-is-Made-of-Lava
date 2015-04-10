using UnityEngine;
using System.Collections;

public class EndlessCharacterFailController : MonoBehaviour {

	public GameObject happyMouth;
	public GameObject sadMouth;
	public GameObject fireEffects;
	public Rigidbody rigidBody;

	public float deathFallDrag = 10.0f;

	void Awake()
	{
		sadMouth.SetActive(false);
		happyMouth.SetActive(true);
		rigidBody =  GetComponent<Rigidbody>();
	}


	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "LavaCollider")
		{
			happyMouth.SetActive(false);
			sadMouth.SetActive(true);
			rigidBody.velocity = -rigidBody.velocity;
			//rigidBody.velocity = Vector3.zero; 
			//rigidBody.drag = deathFallDrag;
			//Instantiate(fireEffects, transform.position, Quaternion.identity);
		}
	}
}

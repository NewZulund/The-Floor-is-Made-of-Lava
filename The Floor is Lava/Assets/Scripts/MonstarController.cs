using UnityEngine;
using System.Collections;

public class MonstarController : MonoBehaviour {

	private EndlessController controller;
	private float startingZ;

	// Use this for initialization
	void Awake () {
		controller = GameObject.Find ("EndlessController").GetComponent<EndlessController> ();
		startingZ = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((12 - controller.currentRunSpeed) * Vector3.back * Time.deltaTime);
		if (transform.position.z > startingZ) {
			transform.Translate(0.0f, 0.0f, startingZ - transform.position.z);
		}
		if (transform.position.z < 0) {
			PauseManagerScript pause = GameObject.Find ("PauseManager").GetComponent<PauseManagerScript> ();
			pause.RestartGame();
		}
	}
}

using UnityEngine;
using System.Collections;

public class MonstarController : MonoBehaviour {

	private EndlessController controller;
	public float startingZ;
	private bool gameIsEnded = false;
	private float backPoint;
	private float diff;
	private bool backing = false;

	// Use this for initialization
	void Awake () {
		controller = GameObject.Find ("EndlessController").GetComponent<EndlessController> ();
		startingZ = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((15 - controller.currentRunSpeed) * Vector3.back * Time.deltaTime);
		if (transform.position.z > startingZ) {
			transform.Translate(0.0f, 0.0f, startingZ - transform.position.z);
		}
		if (transform.position.z < 0 && !gameIsEnded) {

			PauseManagerScript pause = GameObject.Find ("PauseManager").GetComponent<PauseManagerScript> ();
			pause.GameOver();

			gameIsEnded = true;
		}
		if (backing && transform.position.z < backPoint) {
			transform.Translate (0, 0, diff * Time.deltaTime);
		} else if (backing) {
			backing = false;
		}
	}

	public void BackOff (){
		backPoint = (transform.position.z + startingZ) / 2.0f;
		diff = backPoint - transform.position.z;
		backing = true;
	}
}

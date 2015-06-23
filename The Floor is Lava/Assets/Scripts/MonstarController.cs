using UnityEngine;
using System.Collections;

public class MonstarController : MonoBehaviour {

	private EndlessController controller;
	public float startingZ;
	private bool gameIsEnded = false;
	private float backPoint;
	private float diff;
	private bool backing = false;
	private int rotAngle;
	private float increment;

	// Use this for initialization
	void Awake () {
		controller = GameObject.Find ("EndlessController").GetComponent<EndlessController> ();
		startingZ = transform.position.z;
		increment = startingZ / 45f;
		rotAngle = 45;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((15 - controller.currentRunSpeed) * Vector3.back * Time.deltaTime);
		if (transform.position.z > startingZ) {
			transform.Translate(0.0f, 0.0f, startingZ - transform.position.z);
		}
		if (transform.position.z < 8 && !gameIsEnded) {

			PauseManagerScript pause = GameObject.Find ("PauseManager").GetComponent<PauseManagerScript> ();
			pause.GameOver();

			gameIsEnded = true;
		}
		int currAngle = (int) (transform.position.z / increment);
		if (backing && transform.position.z < backPoint) {
			transform.Translate (0, 0, diff * Time.deltaTime);
			transform.Rotate(new Vector3(-(rotAngle - currAngle), 0, 0));
		} else if (backing) {
			backing = false;
		} else {
			transform.Rotate(new Vector3(-(rotAngle - currAngle), 0, 0));
		}
		rotAngle = currAngle;
	}

	public void BackOff (){
		backPoint = (transform.position.z + startingZ) / 2.0f;
		diff = backPoint - transform.position.z;
		backing = true;
	}
}

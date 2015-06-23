using UnityEngine;
using System.Collections;

public class MonstarController : MonoBehaviour {

	private EndlessController controller;
	public float startingZ;
	private bool gameIsEnded = false;
	private float backPoint;
	private float diff;
	private bool backing = false;
	private float rotAngle;
	private float increment;
	private float height;
	public int endPoint;

	// Use this for initialization
	void Awake () {
		controller = GameObject.Find ("EndlessController").GetComponent<EndlessController> ();
		startingZ = transform.position.z;
		increment = startingZ / 450f;
		rotAngle = 450f;
		height = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((15 - controller.currentRunSpeed) * Vector3.back * Time.deltaTime);
		if (transform.position.z > startingZ) {
			transform.Translate(0.0f, 0.0f, startingZ - transform.position.z);
		}
		if (transform.position.z < endPoint && !gameIsEnded) {

			PauseManagerScript pause = GameObject.Find ("PauseManager").GetComponent<PauseManagerScript> ();
			pause.GameOver();

			gameIsEnded = true;
		}
		float currAngle = (transform.position.z / increment);
		if (backing && transform.position.z < backPoint) {
			transform.Translate (0, 0, diff * Time.deltaTime); //(rotAngle - currAngle)/(rotAngle/2 + 1)
			transform.Rotate(new Vector3(-(rotAngle - currAngle)/7, 0, 0));
		} else if (backing) {
			backing = false;
		} else {
			//transform.Translate (0, (rotAngle - currAngle)/(rotAngle/2 + 1), 0);
			transform.Rotate(new Vector3(-(rotAngle - currAngle)/7, 0, 0));
		}
		rotAngle = currAngle;
	}

	public void BackOff (){
		backPoint = (transform.position.z + startingZ) / 2.0f;
		diff = backPoint - transform.position.z;
		backing = true;
	}
}

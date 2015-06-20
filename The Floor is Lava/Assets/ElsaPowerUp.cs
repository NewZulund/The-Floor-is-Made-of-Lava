using UnityEngine;
using System.Collections;

public class ElsaPowerUp : MonoBehaviour {

	public MonstarController controller;

	// Use this for initialization
	void Start () {
		controller = EndlessController.controller.monstarController;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			print ("Hit the player");
			controller.BackOff();
			Destroy(gameObject);
		}
	}
}

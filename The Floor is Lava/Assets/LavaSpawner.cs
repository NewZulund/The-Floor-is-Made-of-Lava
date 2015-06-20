using UnityEngine;
using System.Collections;

public class LavaSpawner : MonoBehaviour {

	public GameObject lavaCanyonPrefab;
	private GameObject lavaCanyon1 = null;
	private GameObject lavaCanyon2 = null;

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			Destroy (child.gameObject);
		}

		lavaCanyon1 = Instantiate (lavaCanyonPrefab);
		lavaCanyon1.transform.SetParent (transform, false);

		lavaCanyon2 = Instantiate (lavaCanyonPrefab);
		lavaCanyon2.transform.localScale = Vector3.one;
		lavaCanyon2.transform.position = Vector3.forward*-820;//new Vector3(0, 0, -820);
		lavaCanyon2.transform.SetParent (transform, false);
	}
	
	// Update is called once per frame
	void Update () {
		if (lavaCanyon2.transform.position.z >= 0) {
			Destroy(lavaCanyon1);
			lavaCanyon1 = lavaCanyon2;

			lavaCanyon2 = Instantiate(lavaCanyonPrefab);
			lavaCanyon2.transform.localScale = Vector3.one;
			lavaCanyon2.transform.position = Vector3.forward*-820;//new Vector3(0, 0, -820);
			lavaCanyon2.transform.SetParent (transform, false);
		}
	}
}

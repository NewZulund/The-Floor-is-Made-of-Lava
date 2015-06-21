using UnityEngine;
using System.Collections;

public class LayoutPrefabSpawner : MonoBehaviour {

	public GameObject[] PlatformLayoutPrefabs;
	private EndlessController controller;

	public float distanceMoved;
	public float spawnDistance;

	void Start()
	{
		controller = EndlessController.controller;
	}

	// Update is called once per frame
	void Update () 
	{
		if(distanceMoved >= spawnDistance)
		{
			//Find a platform starting from the end of the current platform


			//Spawn

			//Set next spawn distance
		}
	}
}

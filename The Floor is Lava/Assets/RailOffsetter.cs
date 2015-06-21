using UnityEngine;
using System.Collections;

public class RailOffsetter : MonoBehaviour {

	public GameObject leftRail;
	public GameObject rightRail;
	public GameObject centerRail;

	void Start()
	{
		/*
		LayoutSpawner spawner = LayoutSpawner.spawner;
		if(spawner)
		{
			leftRail.transform.position = centerRail.transform.position + (Vector3.left * spawner.PLATFORM_ITEM_WIDTH);
			rightRail.transform.position = centerRail.transform.position + (Vector3.right * spawner.PLATFORM_ITEM_WIDTH);
		}
		*/
	}
}

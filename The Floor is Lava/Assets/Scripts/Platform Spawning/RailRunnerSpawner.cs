using UnityEngine;
using System.Collections;

public class RailRunnerSpawner : MonoBehaviour 
{
	

	EndlessController controller; 
	public float initialSpawnDistance = 30;

	//Platform positions
	public float currentZPosition = 0;
	public float lastSpawnedTime = 0;
	public float timeTillNextSpawn = 0f;

	public RunningRail ActiveRail {get; set;}

	//Rail change limiting //TODO determine by game difficulty 
	public float minimumRailChangeTime = 0.5f;
	public float maximimRailChangeTime = 1f;
	public float miniumRailChangeWaitTime; 
	public float maximumRailChangeWaitTime;

	public bool completedInit = false;

	//Lane switching variables
	public float CHANGE_RAIL_PROBABILITY = 0.01f;	

	public PlatformPool pool;
	
	void Start () 
	{
		controller = EndlessController.controller;
	}
	
	public void InitPlatforms()
	{
		currentZPosition = 0;
		EndlessPlatform platform = new EndlessPlatform();

		while(currentZPosition < initialSpawnDistance)
		{
			platform = pool.GetPlatform();
			currentZPosition += (platform.length / 2);
			platform.MoveModelTo(Vector3.back * currentZPosition + ActiveRail.position);
			currentZPosition += (platform.length / 2);
		}

		lastSpawnedTime = Time.time;
		//TODO use actual controller speed
		timeTillNextSpawn = platform.length / 10.0f;
		completedInit = true;
	}

	// Update is called once per frame
	void Update () 
	{
		timeTillNextSpawn -= Time.deltaTime;

		bool railChanged = false;

		if(completedInit)
		{
			if((Random.value <= CHANGE_RAIL_PROBABILITY &&  miniumRailChangeWaitTime < Time.time) || Time.time > maximumRailChangeWaitTime)
			{
				ActiveRail = ActiveRail.GetRandomLinkedRail();
				railChanged = true;
				miniumRailChangeWaitTime = Time.time + minimumRailChangeTime;
				maximumRailChangeWaitTime = Time.time + maximumRailChangeWaitTime;
			}

			//The last platform has moved far enough away that another can be spawned
			if(timeTillNextSpawn <= 0)
			{
				EndlessPlatform platform = pool.GetPlatform();
				platform.MoveModelTo(Vector3.back * (currentZPosition) + ActiveRail.position);
				timeTillNextSpawn = platform.length / controller.runSpeed;
			}


		}

		//Give the player some notification that the rail is changing
		if(railChanged)
		{


		}
	}
}

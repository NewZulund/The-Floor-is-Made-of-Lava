using UnityEngine;
using System.Collections;

public class RailRunnerSpawner : MonoBehaviour 
{

	//Spawning variables
	public RunningRail ActiveRail {get; set;}
	EndlessController controller; 
	public float initialSpawnDistance = 30;

	public float currentZPosition = 0;
	public float lastSpawnedTime = 0;
	public float timeTillNextSpawn = 0f;

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
			if(Random.value <= CHANGE_RAIL_PROBABILITY)
			{
				ActiveRail = ActiveRail.GetRandomLinkedRail();
				railChanged = true;
			}

			//The last platform has moved far enough away that another can be spawned
			if(timeTillNextSpawn <= 0)
			{
				EndlessPlatform platform = pool.GetPlatform();
				platform.MoveModelTo(Vector3.back * (currentZPosition) + ActiveRail.position);
				timeTillNextSpawn = platform.length / controller.runSpeed;
			}


		}
	}
}

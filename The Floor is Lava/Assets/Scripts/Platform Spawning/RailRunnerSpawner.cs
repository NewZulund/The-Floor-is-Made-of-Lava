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

	//TODO make pool
	public GameObject table; 
	public EndlessPlatform platform;




	void Start () 
	{
		controller = EndlessController.controller;
	}
	
	public void InitPlatforms()
	{
		table = Instantiate(table);
		platform = table.GetComponent<EndlessPlatform>();

		currentZPosition = 0;

		//Spawn platforms up to spawn distance
		//TODO use more prefabs
		while(currentZPosition < initialSpawnDistance)
		{
			currentZPosition += (platform.length / 2);
			Instantiate(table, Vector3.back * currentZPosition + ActiveRail.position, Quaternion.identity);
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
				Instantiate(table, Vector3.back * (currentZPosition + platform.length / 2) + ActiveRail.position , Quaternion.identity);
				timeTillNextSpawn = platform.length / controller.runSpeed;
			}


		}
	}
}

using UnityEngine;
using System.Collections;

public class EndlessPropSpawner : MonoBehaviour {

	//Prop Variables
	public PropGroup[] propGroups;
	
	//Rail Variables
	public RunningRail[] rails;
	
	//Spawn Wave Variables
	public float spawnMin = 3f;
	public float spawnMax = 6f;

	public RailRunnerSpawner runningRailPrefab;

	//Runner mode variables
	public bool useRunnerMode = true;
	public bool hasInitialised = false;
	
	void Start()
	{
		if(!useRunnerMode)
		{
			Spawn();
		}
	}

	void Spawn()
	{
		//Select a rail to spawn on. 
		PropGroup selectedPropGroup = propGroups[Random.Range(0,propGroups.Length)];
		RunningRail selectedRail = rails[Random.Range(0,rails.Length)];	

		selectedPropGroup.spawnPlatformSet(selectedRail);
		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
	}

	public void Despawn (Collider other)
	{
		if(other.tag == "Platform")
		{
			EndlessPlatform platform = (EndlessPlatform) other.gameObject.GetComponentInParent<EndlessPlatform>();

			if(platform)
			{
				platform.Despawn();

			}
		}
	}

	public void Update()
	{
		if(useRunnerMode && !hasInitialised)
		{
			RailRunnerSpawner runner = Instantiate(runningRailPrefab) as RailRunnerSpawner;
			runner.ActiveRail = rails[rails.Length / 2]; 
			runner.InitPlatforms();
			hasInitialised = true;
		}
	}
}

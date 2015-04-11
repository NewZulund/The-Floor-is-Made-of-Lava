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

	void Start()
	{
		Spawn();
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
		throw new System.NotImplementedException ();
	}
}

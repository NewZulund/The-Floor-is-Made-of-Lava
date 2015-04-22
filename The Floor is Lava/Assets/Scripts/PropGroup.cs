using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PropGroup : MonoBehaviour
{

	//Prefab Variables
	public EndlessPlatform[] platformPrefabs;

	//Instantiated Variables
	public Queue<EndlessPlatform> inactivePlatforms = new Queue<EndlessPlatform>(); //Instantiated but not in use
	public List<EndlessPlatform> activePlatforms = new List<EndlessPlatform>(); //In use
	public float platformSeperation = 2.5f;


	//Instantiation Variables
	public int INSTANTIATED_PLATFORM_COUNT = 20;
	public Vector3 storagePosition;

	void Start()
	{

		//TODO instantiate various prefabs
		int numberOfEachPlatform = INSTANTIATED_PLATFORM_COUNT / platformPrefabs.Length;

		//Spawn even amounts of prefabs.
		for(int i = 0; i < numberOfEachPlatform; i++)
		{
			for(int j = 0; j < platformPrefabs.Length; j++)
			{
				EndlessPlatform platform = Instantiate(platformPrefabs[j], storagePosition, Quaternion.identity) as EndlessPlatform;
				inactivePlatforms.Enqueue(platform);
				platform.Spawn(storagePosition, Quaternion.identity, this);

			}
		}
	}
	
	private EndlessPlatform getPlatformOfIndex (int index)
	{
		if(index >= platformPrefabs.Length)
		{
			index = 0;
			Debug.Log("Platform doesn't exist at that index!");
		}

		//Get platform from pool or instantiate new if pool is empty
		EndlessPlatform platform;
		if(inactivePlatforms.Count == 0)
		{
			//Debug.Log("Needs more platforms!");
			platform = Instantiate(platformPrefabs[index], storagePosition, Quaternion.identity) as EndlessPlatform;
			platform.Spawn(storagePosition, Quaternion.identity, this);
		}
		else
		{
			platform = inactivePlatforms.Dequeue();
		}

		activePlatforms.Add(platform);
		platform.Enable();
		return platform;
	}

	
	public void spawnPlatformSet (RunningRail selectedRail)
	{

		//TODO make length of platform group random
		for(int i = 0; i < 5; i++)
		{
			//TODO use more than one platform asset if possible
			EndlessPlatform platform = getPlatformOfIndex(Random.Range(0, platformPrefabs.Length));

			//Offset by platform count
			platform.MoveModelTo(selectedRail.startPosition.position + (Vector3.back * platform.length * i));

			//Start moving
			platform.Enable();

		}
	}

	public void despawn (EndlessPlatform endlessPlatform)
	{
		endlessPlatform.Disable();
		endlessPlatform.MoveModelTo(storagePosition);
		activePlatforms.Remove(endlessPlatform);
		inactivePlatforms.Enqueue(endlessPlatform);
	}
}


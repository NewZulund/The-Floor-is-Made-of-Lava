using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PropGroup : MonoBehaviour
{

	//Prefab Variables
	public GameObject[] platformPrefabs;

	//Instantiated Variables
	public List<GameObject> inactivePlatforms = new List<GameObject>(); //Instantiated but not in use
	public List<GameObject> activePlatforms = new List<GameObject>(); //In use
	public float platformSeperation = 2.5f;


	//Instantiation Variables
	public int INSTANTIATED_PLATFORM_COUNT = 20;
	public Vector3 storagePosition;

	void Awake()
	{

		//TODO instantiate various prefabs

		//Spawn even amounts of prefabs.
		for(int i = 0; i < INSTANTIATED_PLATFORM_COUNT; i++){
			inactivePlatforms.Add(Instantiate(platformPrefabs[0], storagePosition, Quaternion.identity) as GameObject);
		}
	}
	
	private GameObject getPlatformOfIndex (int index)
	{
		if(index >= platformPrefabs.Length)
		{
			index = 0;
			Debug.Log("Platform doesn't exist at that index!");
		}

		//Get platform from pool or instantiate new if pool is empty
		GameObject platform;
		if(inactivePlatforms.Count == 0)
		{
			platform = Instantiate(platformPrefabs[index], storagePosition, Quaternion.identity) as GameObject;
		}
		else
		{
			platform = inactivePlatforms[0];
			inactivePlatforms.RemoveAt(0);
		}

		activePlatforms.Add(platform);
		return platform;
	}

	public void spawnPlatformSet (RunningRail selectedRail)
	{

		//TODO make length of platform group random
		for(int i = 0; i < 5; i++)
		{
			//TODO use more than one platform asset if possible
			GameObject platform = getPlatformOfIndex(0);

			//Offset by platform count
			platform.transform.position = selectedRail.position + (Vector3.back * platformSeperation * i);

		}
	}
}


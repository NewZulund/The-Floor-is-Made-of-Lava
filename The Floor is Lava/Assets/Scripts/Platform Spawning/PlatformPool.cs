using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformPool : MonoBehaviour {

	public float instantiatedNumber = 0;
	float numberToInstantiate = 35;

	public EndlessPlatform[] platformPrefabs;
	public Queue<EndlessPlatform> queue = new Queue<EndlessPlatform>();

	Vector3 poolPosition = Vector3.down * 100;

	void Start()
	{
		for(int i = 0; i < numberToInstantiate; i++)
		{
			SpawnPlatform();
			instantiatedNumber++;
		}
	}


	public EndlessPlatform GetPlatform()
	{
		if(queue.Count > 0)
		{
			EndlessPlatform platform = queue.Dequeue();
			platform.Enable();
			return platform;
		}
		else{
			EndlessPlatform platform = SpawnPlatform();
			platform.Enable();
			instantiatedNumber++;
			return platform;
		}

	}

	private EndlessPlatform SpawnPlatform()
	{
		if(platformPrefabs != null)
		{
			EndlessPlatform go = Instantiate(platformPrefabs[0], poolPosition, Quaternion.identity) as EndlessPlatform;
			go.Spawn(poolPosition, Quaternion.identity, this);
			queue.Enqueue(go);
			go.Disable();
			return go;
		}

		return null;
	}

	public void Despawn (EndlessPlatform endlessPlatform)
	{
		endlessPlatform.MoveModelTo(poolPosition);
		queue.Enqueue(endlessPlatform);
		endlessPlatform.Disable();
		Debug.Log("Despawn! ");
	}
}

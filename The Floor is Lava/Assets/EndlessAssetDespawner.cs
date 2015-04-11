using UnityEngine;
using System.Collections;

public class EndlessAssetDespawner : MonoBehaviour {

	EndlessPropSpawner propSpawner;


	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Platform")
		{
			propSpawner.Despawn(other);
		}
	}
}

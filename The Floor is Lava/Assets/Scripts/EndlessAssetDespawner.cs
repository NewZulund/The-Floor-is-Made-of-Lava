using UnityEngine;
using System.Collections;

public class EndlessAssetDespawner : MonoBehaviour {

	public EndlessPropSpawner propSpawner;

	void OnTriggerEnter(Collider other)
	{
		propSpawner.Despawn(other);
	}
}

using UnityEngine;
using System.Collections;

public class EndlessAssetDespawner : MonoBehaviour {

	public EndlessPropSpawner propSpawner;

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Despawn!");
		propSpawner.Despawn(other);
	}
}

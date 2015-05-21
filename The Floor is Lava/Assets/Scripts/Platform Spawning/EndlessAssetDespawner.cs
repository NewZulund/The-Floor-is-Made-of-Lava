using UnityEngine;
using System.Collections;

public class EndlessAssetDespawner : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.tag != "Lava" && other.tag != "LavaCollider" && tag != "LavaSurrounds")
		{
			Destroy(other.gameObject);
		}
	}
}

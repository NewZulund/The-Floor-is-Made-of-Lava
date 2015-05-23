using UnityEngine;
using System.Collections;

public class EndlessAssetDespawner : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.tag != "Lava" && other.tag != "LavaCollider" && other.tag != "LavaSurrounds" && other.tag != "" && other.tag != "Untagged")
		{
			Destroy(other.gameObject);
		}
	}
}

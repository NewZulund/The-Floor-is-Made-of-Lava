using UnityEngine;
using System.Collections;

public class LavaDespawner : MonoBehaviour {

	public EndlessLavaSpawner spawner;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "LavaCollider")
		{
			spawner.RemoveLava(other);
		}

	}
}

using UnityEngine;
using System.Collections;

public class LavaDespawner : MonoBehaviour {

	public EndlessLavaSpawner spawner;

	void OnTriggerEnter(Collider other)
	{
		print("hit");
		if(other.tag == "Lava" || other.tag == "LavaCollider")
		{
			spawner.RemoveLava(other);
		}

	}
}

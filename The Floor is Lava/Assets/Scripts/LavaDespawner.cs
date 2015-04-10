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
		else if (other.tag == "Platform")
		{
			//TODO randomly generate platforms
			spawner.RemoveLava(other);
		}

	}
}

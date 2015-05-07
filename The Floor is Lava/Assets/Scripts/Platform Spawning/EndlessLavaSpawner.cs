using UnityEngine;
using System.Collections;

public class EndlessLavaSpawner : MonoBehaviour 
{
	public Transform spawnPosition;

	public void RemoveLava(Collider collider)
	{
		SpawnLava (collider);
	}

	public void SpawnLava(Collider collider)
	{
		print ("Respawning lava?");
		Transform parentLavaTransform = collider.GetComponentInParent<Transform>();
		parentLavaTransform.position = new Vector3(collider.transform.position.x, collider.transform.position.y, spawnPosition.position.z);
	}


}

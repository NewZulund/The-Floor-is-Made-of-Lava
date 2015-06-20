using UnityEngine;
using System.Collections;

public class CollectableSpawner : MonoBehaviour {

	public float minimumDelay = 2.0f;
	public float maximumDelay = 5.0f;
	public GameObject[] coinLayoutPrefabs;
	LayoutSpawner spawner;

	public ElsaPowerUp snowprefab;
	
	public float yOffset = 1.0f;
	public float zOffset = -20.0f;
	public float startZOffset = -10.0f;

	void Start()
	{
		spawner = LayoutSpawner.spawner;
		GameObject prefab = Instantiate(coinLayoutPrefabs[0], Vector2.zero, Quaternion.identity) as GameObject;
		prefab.transform.Translate(0,yOffset,startZOffset);
		Invoke ("SpawnCollectablePrefab", Random.Range(minimumDelay, maximumDelay));
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.T)) {
			Debug.Log("Roarwojwarojawr");

			Instantiate(snowprefab, Vector3.forward * -10 + Vector3.up, Quaternion.identity);			

		}
	}


	void SpawnCollectablePrefab()
	{
		int index = Random.Range(0, coinLayoutPrefabs.Length);
		GameObject prefab = Instantiate(coinLayoutPrefabs[index],  Vector2.zero, Quaternion.identity) as GameObject;

		int rail = Random.Range(-1,2);
		prefab.transform.Translate(rail * spawner.PLATFORM_ITEM_WIDTH ,yOffset,zOffset);
		Invoke ("SpawnCollectablePrefab", Random.Range(minimumDelay, maximumDelay));
	}

}

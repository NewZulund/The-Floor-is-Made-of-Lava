using UnityEngine;
using System.Collections;

public class CollectableSpawner : MonoBehaviour {

	public float minimumDelay = 2.0f;
	public float maximumDelay = 5.0f;
	public GameObject[] coinLayoutPrefabs;

	public ElsaPowerUp snowprefab;
	
	public float yOffset = 6.0f;
	public float zOffset = -200.0f;

	void Start()
	{
		Invoke ("SpawnCollectablePrefab", Random.Range(minimumDelay, maximumDelay));
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.T)) {
			Instantiate(snowprefab, Vector3.forward * -10 + Vector3.up, Quaternion.identity);			
		}
	}
	
	void SpawnCollectablePrefab()
	{
		int index = Random.Range(0, coinLayoutPrefabs.Length);
		GameObject prefab = Instantiate(coinLayoutPrefabs[index]) as GameObject;

		int rail = Random.Range(-1,2);
		prefab.transform.position = new Vector3(rail,yOffset,zOffset);
		Invoke ("SpawnCollectablePrefab", Random.Range(minimumDelay, maximumDelay));
	}
}

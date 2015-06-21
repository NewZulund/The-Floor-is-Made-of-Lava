using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LayoutSpawner : MonoBehaviour {

	public static LayoutSpawner spawner;
	public EndlessController controller;
	/*
	private string layoutFileName = "Assets/Resources/layouts.csv";
	public  float PLATFORM_ITEM_LENGTH = 3.0f;
	public  float PLATFORM_ITEM_WIDTH = 1.75f;
	public  float NOTIFCATION_HEIGHT = 1.0f;
	public  int START_LAYOUTS = 5;

	public static float SPAWN_TRIGGER_DISTANCE = -30.0f;

	LayoutLoader loader;
	*/
	public List<PlatformLayout> layouts;
	public GameObject parent; 


	public Dictionary<int, PlatformLayout> layoutByIndex;
	public Dictionary<string, List<PlatformLayout>> layoutByIncomingRail;

	public float totalDistance;
	public float nextSpawnDistance;
	public string expectedPlayerRails = "1";
	public float startRunDistance = 10.0f;

	void Awake () 
	{
		if(spawner == null)
		{
			spawner = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}
		
		layoutByIncomingRail = buildIncomingRailDictionary();
		//SpawnLayouts(START_LAYOUTS);
	}

	void Start()
	{
		controller = EndlessController.controller;
	}

	//Find a platform layout that enters from the provided rail index. 
	PlatformLayout getLayoutForLayout (string expectedPlayerRail)
	{
		if(layoutByIncomingRail.ContainsKey(expectedPlayerRails))
		{
			List<PlatformLayout> platforms = layoutByIncomingRail[expectedPlayerRails];
			return platforms[Random.Range(0,platforms.Count)];
		}
		else
		{
			print("Should not have happened: No valid layout! for  " + expectedPlayerRail);
			return layouts[0];
		}
	}


	public void SpawnLayouts(int count)
	{
		for(int i = 0; i < count; i++)
		{
			SpawnLayout();
		}
	}

	public void SpawnLayout()
	{
		//Instantiate a layout that the player expects to enter by passing the expected exit layer
		//from the last layout or 1 if the player is starting in the center. 
		//This means the layout's paths will smoothly blend together
		PlatformLayout layout = getLayoutForLayout(expectedPlayerRails);

		GameObject prefab = Instantiate(layout.prefab);
		prefab.transform.SetParent(parent.transform);
		prefab.transform.localPosition = Vector3.zero;
		
		//Compound total distance to offset later layouts
		expectedPlayerRails = layout.endRails;
		nextSpawnDistance = totalDistance + layout.length;
	}
	
	void Update()
	{
		totalDistance += controller.currentRunSpeed * Time.deltaTime;
		if(totalDistance > nextSpawnDistance)
		{
			SpawnLayout ();
		}
	}
	/**
	 * Builld a dictonary from outgoing rails to layouts that can accept those rails. 
	 * This list is used to spawn plausable layouts for the ends of pre-spawned layouts.
	 */

	private Dictionary<string, List<PlatformLayout>> buildIncomingRailDictionary()
	{
		Dictionary<string, List<PlatformLayout>> layoutDictionary = new Dictionary<string, List<PlatformLayout>>();

		foreach(PlatformLayout layout in layouts)
		{
			if(layoutDictionary.ContainsKey(layout.startRails))
			{
				layoutDictionary[layout.startRails].Add(layout);
			}
			else
			{
				List<PlatformLayout> list = new List<PlatformLayout>();
				list.Add(layout);
				layoutDictionary.Add(layout.startRails, list);
			}
		}

		return layoutDictionary;
	}
}

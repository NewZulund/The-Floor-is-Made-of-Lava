using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LayoutSpawner : MonoBehaviour {

	private string layoutFileName = "Assets/Resources/layouts.csv";
	public static float PLATFORM_ITEM_LENGTH = 3.0f;
	public static float PLATFORM_ITEM_WIDTH = 1.75f;
	public static float NOTIFCATION_HEIGHT = 1.0f;
	public static int START_LAYOUTS = 5;

	public static float SPAWN_TRIGGER_DISTANCE = -30.0f;

	LayoutLoader loader;
	public List<PlatformLayout> layouts;

	public Dictionary<int, PlatformLayout> layoutByIndex;
	public Dictionary<string, List<PlatformLayout>> layoutByIncomingRail;

	public GameObject[] assetPrefabs;
	public GameObject[] notificationPrefabs;
	
	public EndlessController controller;
	public float totalDistance = 0.0f;
	public string expectedPlayerRails = "1";

	private GameObject parent; 
	
	void Awake () 
	{
		loader = GetComponent<LayoutLoader>();
		layouts = loader.Load(layoutFileName);
		layoutByIncomingRail = buildIncomingRailDictionary();

		parent = new GameObject();
		parent.name = "PlatformLayouts";
		parent.AddComponent<EndlessPropMover>();
		
		SpawnLayouts(START_LAYOUTS);

	}

	void Start()
	{
		controller = EndlessController.controller;
	}

	//Find a platform layout that enters from the provided rail index. 
	PlatformLayout getLayoutForLayout (string expectedPlayerRail)
	{
		//TODO make this accept a list of ints and try find layouts that match all cases if possible. 

		if(layoutByIncomingRail.ContainsKey(expectedPlayerRails))
		{
			List<PlatformLayout> platforms = layoutByIncomingRail[expectedPlayerRails];
			return platforms[Random.Range(0,platforms.Count)];
		}
		else
		{
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


		//Instantiate platforms
		for(int y = 0; y < layout.length; y++)
		{
			for(int x = 0; x < layout.width; x++)
			{
				GameObject platform = null;
				Vector3 offset = transform.forward * totalDistance + y * PLATFORM_ITEM_LENGTH * -transform.forward + transform.right * x * PLATFORM_ITEM_WIDTH - transform.right * layout.width / 2 ;

				//Platforms 
				int itemIndex = layout.platformArray[y][x];
				if(itemIndex < assetPrefabs.Length && itemIndex >= 0)
				{

					platform = Instantiate(assetPrefabs[itemIndex], transform.position + offset, Quaternion.identity) as GameObject;
					platform.transform.parent = parent.transform;

				}

				//Notifications
				itemIndex = layout.notificationArray[y][x];
				if(itemIndex < notificationPrefabs.Length && itemIndex >= 0)
				{
					GameObject notification = Instantiate(notificationPrefabs[itemIndex], transform.position + offset + (Vector3.up * NOTIFCATION_HEIGHT), Quaternion.identity) as GameObject;
					notification.transform.parent = parent.transform;
				}
			}
			
		}
		
		//Compound total distance to offset later layouts
		totalDistance -= PLATFORM_ITEM_LENGTH * layout.length;
		expectedPlayerRails = layout.endRailsString;
	}
	
	void Update()
	{
		totalDistance += controller.currentRunSpeed * Time.deltaTime;
		if(totalDistance > SPAWN_TRIGGER_DISTANCE)
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
			if(layoutDictionary.ContainsKey(layout.startRailsString))
			{
				layoutDictionary[layout.startRailsString].Add(layout);
			}
			else
			{
				List<PlatformLayout> list = new List<PlatformLayout>();
				list.Add(layout);
				layoutDictionary.Add(layout.startRailsString, list);
			}
		}

		//DEBUG
		List<string> keys = new List<string>(layoutDictionary.Keys);

		return layoutDictionary;
	}
}

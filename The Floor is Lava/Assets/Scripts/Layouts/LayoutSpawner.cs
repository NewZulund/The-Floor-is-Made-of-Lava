using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LayoutSpawner : MonoBehaviour {

	private string layoutFileName = "Assets/Resources/layouts.csv";
	public static float PLATFORM_ITEM_LENGTH = 3.0f;
	public static float PLATFORM_ITEM_WIDTH = 1.75f;
	public static int START_LAYOUTS = 5;

	public static float SPAWN_TRIGGER_DISTANCE = -30.0f;

	LayoutLoader loader;
	public List<PlatformLayout> layouts;

	public Dictionary<int, PlatformLayout> layoutByIndex;
	public Dictionary<int, List<PlatformLayout>> layoutByIncomingRail;

	public GameObject[] assetPrefabs;
	
	public EndlessController controller;
	public float totalDistance = 0.0f;
	public int expectedPlayerRail = 1;

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
	PlatformLayout getLayoutForLayout (int expectedPlayerRail)
	{
		//TODO make this accept a list of ints and try find layouts that match all cases if possible. 
		if(layoutByIncomingRail.ContainsKey(expectedPlayerRail))
		{
			List<PlatformLayout> platforms = layoutByIncomingRail[expectedPlayerRail];
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
		PlatformLayout layout = getLayoutForLayout(expectedPlayerRail);


		//Instantiate platforms
		for(int y = 0; y < layout.length; y++)
		{
			for(int x = 0; x < layout.width; x++)
			{
				int itemIndex = layout.platformArray[y][x];
				if(itemIndex >= assetPrefabs.Length || itemIndex < 0)
				{
					continue;
				}
				
				
				Vector3 offset = transform.forward * totalDistance + y * PLATFORM_ITEM_LENGTH * -transform.forward + transform.right * x * PLATFORM_ITEM_WIDTH - transform.right * layout.width / 2 ;
				GameObject platform = Instantiate(assetPrefabs[itemIndex], transform.position + offset, Quaternion.identity) as GameObject;
				platform.transform.parent = parent.transform;
			}
			
		}
		
		//Compound total distance to offset later layouts
		totalDistance -= PLATFORM_ITEM_LENGTH * layout.length;
		expectedPlayerRail = layout.endRails[Random.Range(0, layout.endRails.Length)];
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
	 * Builld a dictonary from incoming rails to layouts that can accept those rails. 
	 * This list is used to spawn plausable layouts for the ends of pre-spawned layouts.
	 */
	private Dictionary<int, List<PlatformLayout>> buildIncomingRailDictionary()
	{
		Dictionary<int, List<PlatformLayout>> layoutDictionary = new Dictionary<int, List<PlatformLayout>>();

		foreach(PlatformLayout layout in layouts)
		{
			for(int i = 0; i < layout.startRails.Length; i++)
			{
				if(layoutDictionary.ContainsKey(layout.startRails[i]))
				{
					layoutDictionary[layout.startRails[i]].Add(layout);
				}
				else
				{
					List<PlatformLayout> list = new List<PlatformLayout>();
					list.Add(layout);
					layoutDictionary.Add(layout.startRails[i], list);
				}
			}
		}

		return layoutDictionary;
	}


}

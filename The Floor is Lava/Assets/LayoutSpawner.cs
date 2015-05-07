using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LayoutSpawner : MonoBehaviour {

	public string layoutFileName = "Assets/layout_files/layouts.csv";

	LayoutLoader loader;
	public List<PlatformLayout> layouts;

	public Dictionary<int, PlatformLayout> layoutByIndex;
	public Dictionary<int, List<PlatformLayout>> layoutByIncomingRail;


	void Awake () 
	{
		loader = GetComponent<LayoutLoader>();
		layouts = loader.Load(layoutFileName);
		layoutByIncomingRail = buildIncomingRailDictionary();

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

	public void SpawnLayout(int index)
	{
		//TODO
	}
}

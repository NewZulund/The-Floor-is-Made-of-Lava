using UnityEngine;
using System.Collections;

public class EndlessPropSpawner : MonoBehaviour {
	
	//Rail Variables
	public RunningRail[] rails;
	public RailRunnerSpawner runner;

	//Runner mode variables
	public bool hasInitialised = false;

	public void Despawn (Collider other)
	{
		if(other.tag == "Platform")
		{
			EndlessPlatform platform = (EndlessPlatform) other.gameObject.GetComponentInParent<EndlessPlatform>();

			if(platform)
			{
				platform.Despawn();

			}
		}
	}

	public void Update()
	{
		if(!hasInitialised)
		{
			runner.ActiveRail = rails[rails.Length / 2]; 
			runner.InitPlatforms();
			hasInitialised = true;
		}
	}
}

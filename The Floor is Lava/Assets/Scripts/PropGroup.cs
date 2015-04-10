using UnityEngine;
using System.Collections;

public class PropGroup : MonoBehaviour
{
	//Prop Variables
	public GameObject[] assets; 

	//Group Variables
	public float length = 100f;

	
	public GameObject getRandomAsset ()
	{
		//TODO make less random
		return assets[Random.Range(0, assets.Length)];
	}
}


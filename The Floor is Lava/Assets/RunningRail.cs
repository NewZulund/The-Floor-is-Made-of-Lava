using UnityEngine;
using System.Collections;

public class RunningRail : MonoBehaviour {


	//Player Movement Variables
	public RunningRail leftRail;
	public RunningRail rightRail;
	public Vector3 position 
	{
		get{return this.transform.position;} 
		set{this.transform.position = value;}
	}

	//Model Spawner Variables
	public Transform startPosition;

}

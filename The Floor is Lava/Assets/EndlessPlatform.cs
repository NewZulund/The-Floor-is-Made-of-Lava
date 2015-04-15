using UnityEngine;
using System.Collections;

public class EndlessPlatform : MonoBehaviour {

	public float length = 2.8f;
	public GameObject model;
	public EndlessPropMover moverController; 
	public PropGroup propGroup;
	public Vector3 poolPosition = Vector3.zero;

	void Start()
	{
		moverController = GetComponent<EndlessPropMover>();
	}

	public void Spawn(Vector3 position, Quaternion rotation, PropGroup group)
	{
		propGroup = group;
		model.transform.position = position;
		model.transform.rotation = rotation;
	}

	public void Despawn ()
	{
		if(propGroup)
		{
			propGroup.despawn(this);
		}
		else
		{
			Destroy(this);
		}

	}

	public void MoveToPool ()
	{
		model.transform.position = poolPosition;
	}

	public void MoveModelTo(Vector3 position)
	{
		model.transform.position = position;
	}

	public void Disable ()
	{
		if(moverController)
		{
			moverController.enabled = false;
		}
	}

	public void Enable()
	{
		if(moverController)
		{
			moverController.enabled = true;
		}
	}
}

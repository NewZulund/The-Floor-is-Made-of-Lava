using UnityEngine;
using System.Collections;

public class EndlessPlatform : MonoBehaviour {

	public float length = 2.8f;
	public GameObject model;
	public EndlessPropMover moverController; 
	public PlatformPool pool;

	void Start()
	{
		moverController = GetComponent<EndlessPropMover>();
	}

	public void Spawn(Vector3 position, Quaternion rotation, PlatformPool pool)
	{
		this.pool = pool;
		model.transform.position = position;
		model.transform.rotation = rotation;
	}

	public void Despawn ()
	{
		if(pool)
		{
			pool.Despawn(this);
		}
		else
		{
			Destroy(this.gameObject);
		}
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

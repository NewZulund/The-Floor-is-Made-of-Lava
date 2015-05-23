using UnityEngine;
using System.Collections;

public class PlayerCollection : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Collectable")
		{
			Collectable collectable = other.GetComponent<Collectable>();
			if(collectable)
			{
				EndlessController.controller.PickUp(collectable);
				//TODO add some pretty pickup animation maybe
				Destroy(other.gameObject);
			}
		}
	}
}

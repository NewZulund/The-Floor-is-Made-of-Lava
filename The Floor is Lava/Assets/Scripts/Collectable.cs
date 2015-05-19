using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	public enum CollectableType {Coin};

	public int value = 100;
	public CollectableType type = CollectableType.Coin;

	void OnTriggerEnter(Collider other)
	{
		print ("fuck" + other.gameObject.tag);
		if(other.gameObject.tag == "Player")
		{
			print ("fuck");
			EndlessController.controller.PickUp(this);
			//TODO add some pretty pickup animation maybe
			Destroy(this.gameObject);
		}
	}
}

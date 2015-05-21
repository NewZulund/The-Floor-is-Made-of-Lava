using UnityEngine;
using System.Collections;

public class PlayerMoveHit : MonoBehaviour {

	public EndlessCharacterController controller;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Platform")
		{
			controller.PlayerSideHit();
		}
	}
}

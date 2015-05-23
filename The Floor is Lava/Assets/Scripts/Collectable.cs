using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	public enum CollectableType {Coin};

	public int value = 100;
	public CollectableType type = CollectableType.Coin;
}

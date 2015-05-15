using UnityEngine;
using System.Collections;

public class MoveNotification : MonoBehaviour {
	
	public int moveType;
	public int position;
	public float timeOut = 3.0f;
	public GameObject UIElement;

	void Start()
	{
		Invoke ("FadeOut", timeOut);
	}

	void FadeOut()
	{
		Destroy (this.gameObject);
	}

}

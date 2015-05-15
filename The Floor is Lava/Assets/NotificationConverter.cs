using UnityEngine;
using System.Collections;

public class NotificationConverter : MonoBehaviour {

	public float SPLIT_RAIL_DISTANCE = 0.5f;
	
	public GameObject[] notifications; 

	public GameObject currentNotification; 

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Notification")
		{
			MoveNotification notification = other.GetComponent<MoveNotification>();

			SetNotification(notification.moveType);

			Destroy(other.gameObject);
		}
	}

	void SetNotification(int index)
	{

		if (currentNotification && currentNotification.activeInHierarchy) 
		{
			currentNotification.SetActive(false);
		}

		if(index >= 0 && index < notifications.Length)
		{
			currentNotification = notifications[index];
			currentNotification.SetActive(true);
		}

	}

}
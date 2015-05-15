using UnityEngine;
using System.Collections;

public class NotificationConverter : MonoBehaviour {

	public float SPLIT_RAIL_DISTANCE = 0.5f;
	public float notificationTime = 1.0f;
	
	public GameObject[] notifications; 

	public GameObject currentNotification; 

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Notification")
		{
			MoveNotification notification = other.GetComponent<MoveNotification>();

			if(notification)
			{
				SetNotification(notification.moveType);
			}

			Destroy(other.gameObject);
		}
	}

	void SetNotification(int index)
	{
		//Terminate existing invokes to ensure meeting notificationTime. 
		CancelInvoke("DisableNotification");

		if (currentNotification && currentNotification.activeInHierarchy) 
		{
			currentNotification.SetActive(false);
		}

		if(index >= 0 && index < notifications.Length)
		{
			currentNotification = notifications[index];
			currentNotification.SetActive(true);
		}

		Invoke ("DisableNotification",notificationTime);

	}

	void DisableNotification()
	{
		if(currentNotification)
		{
			currentNotification.SetActive(false);
		}
	}

}
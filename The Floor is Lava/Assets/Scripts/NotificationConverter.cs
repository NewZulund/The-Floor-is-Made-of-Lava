using UnityEngine;
using System.Collections;

public class NotificationConverter : MonoBehaviour {

	public float SPLIT_RAIL_DISTANCE = 0.5f;
	public float notificationTime = 1.0f;
	
	public GameObject[] notifications; 

	/// <summary>
	/// Raises the trigger enter event.
	/// </summary>
	/// <param name="other">Other.</param>
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

	/// <summary>
	/// Sets the indexed notification to visible and invokes a disable on the same notification
	/// </summary>
	/// <param name="index">Index.</param>
	void SetNotification(int index)
	{
		//Terminate existing invokes to ensure meeting notificationTime. 
		CancelInvoke("DisableNotification");

		if(index >= 0 && index < notifications.Length)
		{
			notifications[index].SetActive(true);
		}

		StartCoroutine ("DisableNotification", index);

	}

	/// <summary>
	/// Disables the notification.
	/// </summary>
	/// <returns>The notification.</returns>
	/// <param name="index">Index.</param>
	IEnumerator DisableNotification(int index)
	{
		yield return new WaitForSeconds(notificationTime);

		if(index >= 0 && index < notifications.Length && notifications[index])
		{
			notifications[index].SetActive(false);
		}
	}

}
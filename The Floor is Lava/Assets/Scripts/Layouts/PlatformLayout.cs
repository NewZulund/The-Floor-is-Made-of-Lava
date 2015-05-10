using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlatformLayout : System.Object {

	public string name;
	public int number, width, length;
	public int[][] platformArray, notificationArray;
	public int[] startRails, endRails;

}

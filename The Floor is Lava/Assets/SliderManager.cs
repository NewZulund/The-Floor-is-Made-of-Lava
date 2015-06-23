using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderManager : MonoBehaviour {

	private Slider slider;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		print(slider.value);
		print(EndlessController.controller.monstarController.mPercentage());
		slider.value = (EndlessController.controller.monstarController.mPercentage())/100f;
	}
}

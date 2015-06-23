﻿using UnityEngine;
using System.Collections;

public class ComboManager : MonoBehaviour {

	private static bool inComboMode = false;
	private static float countdown = 0;

	public GameObject comboOverlay;

	
	public Material iceSky;
	public Material standardSky;

	public GameObject lavaModel;
	public Material lavaNormalMaterial;
	public Material lavaIceMaterial;

	public GameObject wave;
	public Material normalWaveMaterial;
	public Material iceWaveMaterial;


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "IceCombo") {
			if(inComboMode){
				//add another 5 seconds to combo time
				countdown+=5;
			}
			else{
				inComboMode = true;
				countdown = 5;//combo ends once Time.deltaTime catches up to 'countdown' 
				comboOverlay.SetActive(true);
				wave.GetComponent<Renderer>().material = iceWaveMaterial;
				lavaModel.GetComponent<Renderer>().material = lavaIceMaterial;
				RenderSettings.skybox = iceSky;
				EndlessController.controller.currentRunSpeed = EndlessController.controller.currentRunSpeed * 1.5f;

			}

			Destroy (other.gameObject);
		}
	}

	public void Toggle()
	{
		inComboMode = true;
				countdown = 5;//combo ends once Time.deltaTime catches up to 'countdown' 
				comboOverlay.SetActive(true);
				wave.GetComponent<Renderer>().material = iceWaveMaterial;
				lavaModel.GetComponent<Renderer>().material = lavaIceMaterial;
				RenderSettings.skybox = iceSky;
				EndlessController.controller.currentRunSpeed = EndlessController.controller.currentRunSpeed * 1.5f;
	}

	// Update is called once per frame
	void Update () {
		if (inComboMode) {
			countdown-=Time.deltaTime;
			if(countdown <= 0){
				//combo has ended
				inComboMode = false;
				countdown = 0;
				comboOverlay.SetActive(false);

				wave.GetComponent<Renderer>().material = normalWaveMaterial;
				lavaModel.GetComponent<Renderer>().material = lavaNormalMaterial;
				RenderSettings.skybox = standardSky;
				EndlessController.controller.currentRunSpeed = EndlessController.controller.runSpeed;


			}
		}
	}
}

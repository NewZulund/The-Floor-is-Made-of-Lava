using UnityEngine;
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
				wave.Material = iceWaveMaterial;
				lavaModel.Material = lavaIceMaterial;
				RenderSettings.skybox = iceSky;
			}

			Destroy (other.gameObject);
		}
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

				wave.Material = normalWaveMaterial;
				lavaModel.Material = lavaNormalMaterial;
				RenderSettings.skybox = standardSky;


			}
		}
	}
}

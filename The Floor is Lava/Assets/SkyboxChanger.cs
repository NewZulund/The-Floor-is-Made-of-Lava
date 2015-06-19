using UnityEngine;
using System.Collections;

public class SkyboxChanger : MonoBehaviour {

	public Material iceSkybox;
	public Material standardSkybox;

	public void SwitchToIceSkyBox()
	{
		RenderSettings.skybox = iceSkybox;
	}

	public void SwitchToStandardSkybox()
	{
		RenderSettings.skybox = standardSkybox;
	}
}

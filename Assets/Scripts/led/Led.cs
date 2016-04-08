using UnityEngine;
using System.Collections;

public class Led : MonoBehaviour {


	private Material material;
	private Light light;

	public  int anode_voltage = -1;
	public  int cathode_voltage = -1;

	// Use this for initialization

	void Start () 
	{
		//get the light
		light = gameObject.GetComponent<Light>();

		//turn off the light
		light.intensity = 0f;

		// get the material
		material = gameObject.GetComponent<MeshRenderer>().material;

		//enable emission
		material.EnableKeyword ("_EMISSION");

		//turn the led off
		material.SetColor ("_EmissionColor",new Color (0f,0f,0f,0f));


		//StartCoroutine (led_blink(0.5f));





	}


	public void turn_on()
	{
		// turn led on
		material.SetColor ("_EmissionColor",new Color (1f,0f,0f,1f));

		// turn light on
		light.intensity = 9f;

	}

	public void turn_off()
	{
		// turn led on
		material.SetColor ("_EmissionColor",new Color (0f,0f,0f,0f));

		// turn light on
		light.intensity = 0f;

	}

	IEnumerator led_blink(float delay)
	{
		turn_on ();
		yield return new WaitForSeconds (delay);
		turn_off ();
		yield return new WaitForSeconds (delay);

	}

	void Update()
	{
		if ((anode_voltage - cathode_voltage) == 5) {
			turn_on ();
		}
		else 
		{
			turn_off ();
		}



	}
}

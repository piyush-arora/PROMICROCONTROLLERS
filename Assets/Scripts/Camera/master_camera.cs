using UnityEngine;
using System.Collections;

public class master_camera : MonoBehaviour {

	// Update is called once per frame
	public Camera top_camera;
	public Camera left_camera;
	public Camera right_camera;
	public Camera front_camera;
	public Camera back_camera;
	public Camera bottom_camera;


	void Start()
	{
		top_camera.enabled = true;
		left_camera.enabled = false;
		right_camera.enabled = false;
		front_camera.enabled = false;
		back_camera.enabled = false;
		bottom_camera.enabled = false;



	}


	void Update () 
	{


		if (Input.GetKeyDown ("1")) 
		{
			top_camera.enabled = true;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;

		}

		else if (Input.GetKeyDown ("2")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = true;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;

		}

		else if (Input.GetKeyDown ("3")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = true;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;

		}

		else if (Input.GetKeyDown ("4")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = true;
			back_camera.enabled = false;
			bottom_camera.enabled = false;

		}

		else if (Input.GetKeyDown ("5")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = true;
			bottom_camera.enabled = false;

		}

		else if (Input.GetKeyDown ("6")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = true;

		}
	
	}
}

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

	public Camera Random_Camera;
	public Camera Free_Camera;

	void Start()
	{
		top_camera.enabled = false;
		left_camera.enabled = false;
		right_camera.enabled = false;
		front_camera.enabled = false;
		back_camera.enabled = false;
		bottom_camera.enabled = false;
		Random_Camera.enabled = true;
		Free_Camera.enabled = false;

	}


	void Update () 
	{


		if (Input.GetKeyDown ("0")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;
			Random_Camera.enabled = true;
			Free_Camera.enabled = false;
		}

		else if (Input.GetKeyDown ("1")) 
		{
			top_camera.enabled = true;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;
			Random_Camera.enabled = false;
			Free_Camera.enabled = false;
		}

		else if (Input.GetKeyDown ("2")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = true;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;
			Random_Camera.enabled = false;
			Free_Camera.enabled = false;
		}

		else if (Input.GetKeyDown ("3")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = true;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;
			Random_Camera.enabled = false;
			Free_Camera.enabled = false;
		}

		else if (Input.GetKeyDown ("4")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = true;
			back_camera.enabled = false;
			bottom_camera.enabled = false;
			Random_Camera.enabled = false;
			Free_Camera.enabled = false;
		}

		else if (Input.GetKeyDown ("5")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = true;
			bottom_camera.enabled = false;
			Random_Camera.enabled = false;
			Free_Camera.enabled = false;
		}

		else if (Input.GetKeyDown ("6")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = true;
			Random_Camera.enabled = false;
			Free_Camera.enabled = false;
		}

		else if (Input.GetKeyDown ("7")) 
		{
			top_camera.enabled = false;
			left_camera.enabled = false;
			right_camera.enabled = false;
			front_camera.enabled = false;
			back_camera.enabled = false;
			bottom_camera.enabled = false;
			Random_Camera.enabled = false;
			Free_Camera.enabled = true;
		}
	}
}

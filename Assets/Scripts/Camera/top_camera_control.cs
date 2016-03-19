using UnityEngine;
using System.Collections;

public class top_camera_control : MonoBehaviour 
{


	// Update is called once per frame
	void Update () 
	{
		Vector3 position = gameObject.transform.position;
		float mouse_scroll = Input.GetAxis("Mouse ScrollWheel");
		if(Input.GetKeyDown("left"))
		{
			//Debug.Log ("MOVE CAMERA DOWN");

			position = gameObject.transform.position;
			position.z = position.z - 10f;
			gameObject.transform.position = position;

		}

		else if(Input.GetKeyDown("right"))
		{
			//Debug.Log ("MOVE CAMERA DOWN");

			position = gameObject.transform.position;
			position.z = position.z + 10f;
			gameObject.transform.position = position;

		}

		else if(Input.GetKeyDown("up"))
		{
			//Debug.Log ("MOVE CAMERA DOWN");

			position = gameObject.transform.position;
			position.x = position.x - 10f;
			gameObject.transform.position = position;

		}

		else if(Input.GetKeyDown("down"))
		{
			//Debug.Log ("MOVE CAMERA DOWN");

			position = gameObject.transform.position;
			position.x = position.x + 10f;
			gameObject.transform.position = position;

		}


		else if (mouse_scroll > 0f) 
		{
			position = gameObject.transform.position;
			position.y = position.y + 1f;
			gameObject.transform.position = position;

		}
		else if (mouse_scroll < 0f) 
		{
			position = gameObject.transform.position;
			position.y = position.y - 1f;
			gameObject.transform.position = position;

		}
	
	}
}

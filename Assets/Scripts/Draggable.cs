using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour 
{
	private bool dragging = false;


	void OnMouseEnter()
	{

		//Debug.Log ("SHOW THAT THE MOUSE IS ON Object");

	}

	void OnMouseExit()
	{
		//Debug.Log ("HIDE WHATEVER WE HAVE SHOWN");


	}

	void OnMouseDown()
	{
		//Debug.Log ("PICK UP THE OBJECT");

		dragging = true;


	}

	void OnMouseUp()
	{
		//Debug.Log ("PUT DOWN THE Onject");
		dragging = false;

	}

	void Update()
	{
		if(dragging == true)
		{
			Vector3 position = Input.mousePosition;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			Vector3 raypoint = ray.GetPoint (Vector3.Distance(transform.position,Camera.main.transform.position));


			position.y = gameObject.transform.position.y;
			position.x = raypoint.x;;
			position.z = raypoint.z;

			gameObject.transform.position = position;
		}


	}



}

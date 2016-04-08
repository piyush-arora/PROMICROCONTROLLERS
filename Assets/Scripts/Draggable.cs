using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour 
{
	private bool dragging = false;

	private MouseManager mm ;


	void Start()
	{
		mm = GameObject.FindObjectOfType <MouseManager>();

	}
	void OnMouseEnter()
	{

		//Debug.Log ("SHOW THAT THE MOUSE IS ON Object");
		if (gameObject.tag != "UnTagged") {
			mm.hoveredObject = gameObject;
			mm.HoveredObject (gameObject);
		}


	}

	void OnMouseExit()
	{
		//Debug.Log ("HIDE WHATEVER WE HAVE SHOWN");
		mm.Load_Color_Full(gameObject);
		mm.hoveredObject = null;

	}

	void OnMouseDown()
	{
		//Debug.Log ("PICK UP THE OBJECT");

		dragging = true;
		if (mm.hoveredObject == true) {
			mm.selectedObject = gameObject;
			mm.Set_Color_Full (gameObject, Color.green);
		}
	}

	void OnMouseUp()
	{
		//Debug.Log ("PUT DOWN THE Onject");
		dragging = false;
		mm.selectedObject = null;
		mm.Load_Color_Full (gameObject);
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

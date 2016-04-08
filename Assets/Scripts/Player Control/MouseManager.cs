using UnityEngine;
using System.Collections;

public class MouseManager : MonoBehaviour {


	// hovered with left click
	public GameObject selectedObject = null;

	// hovered
	public GameObject hoveredObject = null;
	// Use this for initialization



	private static Color[,] Saved_Colors;
	private static bool save_color = false;




	void Start () 
	{
		Saved_Colors = new Color[200,200];
	}
	
	// Update is called once per frame
	void Update () 
	{



	}


	// Hovering the object
	public void HoveredObject(GameObject obj)
	{
		// save the original material color
		if(save_color == false)
			Save_Color_Full (obj);

			//ClearSelection();

		Set_Color_Full (hoveredObject,Color.green);
	}


	public void Set_Color_Full(GameObject obj , Color color)
	{
		Renderer[] rs = obj.GetComponentsInChildren<Renderer>();
		foreach(Renderer r in rs) 
		{
			Material[] ms = r.materials;
			foreach (Material m in ms) {

				m.color = color;
				r.material = m;
			}
		}

	}


	// Save the orginal material color of the gameobject in Sved_colors array
	public void Save_Color_Full(GameObject obj)
	{
		// Find all the renderers
		Renderer[] rs = obj.GetComponentsInChildren<Renderer>();
		//Debug.Log(rs.Length);

		for (int i = 0; i < rs.Length; i++) 
		{
			int j = 0;
			Material[] ms = rs [i].materials;
			foreach (Material m in ms) 
			{

				Saved_Colors [i,j] = m.color; 
				rs [i].materials [j] = m;
				//Debug.Log (Saved_Colors[i,j]);

				j++;

			}

		}
		save_color = true;

	}


	public void Load_Color_Full(GameObject obj)
	{
		save_color = false;
		Renderer[] rs = obj.GetComponentsInChildren<Renderer>();

		for (int i = 0; i < rs.Length; i++) 
		{
			int j = 0;
			Material[] ms = rs [i].materials;
			foreach (Material m in ms) 
			{
				m.color = Saved_Colors [i,j]; 
				rs [i].materials [j] = m;

				j++;

			}

		}

	}


		}





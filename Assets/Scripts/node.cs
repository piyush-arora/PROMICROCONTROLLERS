using UnityEngine;
using System.Collections;

public class node : MonoBehaviour 
{

	/*
	 * Line 
	 */
	public GameObject line_object;
	private LineRenderer line;

	/*
	 * Every Source Node must have a receiving node
	 */
	public static GameObject receiving_node;

	// Every Node will have certain voltage
	// It can be HIGH (true), LOW(false) , OPEN(null) 
	public int voltage = -1;


	// Circuit ERROR
	private bool circuit_error = false;

	void Start()
	{

		/*
		 * Initialize the node voltage based on its TAG
		 */

		// VCC TAG
		if (gameObject.tag == "VCC") {
			voltage = 5;

		}

		//GND TAG
		else if (gameObject.tag == "GND") 
		{
			voltage = 0;
		}

		/*
		 * Initialize Line with 2 vertexes
		 */
		line = line_object.GetComponent<LineRenderer> ();
		line.SetVertexCount (2);

		/* 
		 * Hide the node
		 */

		gameObject.GetComponent<MeshRenderer> ().enabled = false;


	}

	void OnMouseEnter()
	{
		//Debug.Log ("MOUSE ENTER "+ gameObject.name);
		/*
		 * Chances are that this might be a receiving node if after coming to this function it never goes to OnMouseExit() function
 		 */
		receiving_node = gameObject;

	}

	void OnMouseExit()
	{
		//Debug.Log ("MOUSE EXIT "+ gameObject.name);

		/*
		 * This node is not receving node as it is just a node which mouse passes from
		 */
		receiving_node = null;
	}

	void OnMouseDown()
	{
		
		/*
		 * Starting a new connection
		 */
		gameObject.GetComponent<MeshRenderer> ().enabled = true;  // show the node

		// Get the starting line cursor position
		line.SetPosition (0, gameObject.transform.position);  // start point of connection

	}

	void OnMouseUp()
	{
		
		/*
		 * Check do we have the receiving node when the mouse is up 
		 */
		if (receiving_node != null) 
		{
			// We finally get the receiving node here 	

			// Get the position of the receiving node
			line.SetPosition (1, receiving_node.transform.position);

			// Create the connection i.e. Line
			Instantiate (line);

			//Show the jumper of the receiving node
			receiving_node.GetComponent<MeshRenderer> ().enabled = true;	

			/*
			 * Make Sure that the receiving node is at the same potential as that of the sending node
			 */

			// check if the receiving node has no voltage i.e. the receiving node is open

			if (receiving_node.transform.parent.gameObject.GetComponent<Bread>().voltage == -1) {
				//receiving_node.GetComponent<node> ().voltage = gameObject.GetComponent<node> ().voltage;
				receiving_node.transform.parent.gameObject.GetComponent<Bread>().voltage = gameObject.transform.parent.gameObject.GetComponent<Bread>().voltage;
			}

			// check if the sending node has no voltage i.e. the sending node is open

			else if (gameObject.transform.parent.gameObject.GetComponent<Bread>().voltage == -1) {
				//gameObject.GetComponent<node> ().voltage = receiving_node.GetComponent<node> ().voltage;
				gameObject.transform.parent.gameObject.GetComponent<Bread>().voltage = receiving_node.transform.parent.gameObject.GetComponent<Bread>().voltage;
			}

			// if we are shoring VCC AND GROUND , RAISE THE CIRCUIT ERROR

			else if (gameObject.transform.parent.gameObject.GetComponent<Bread>().voltage != receiving_node.transform.parent.gameObject.GetComponent<Bread>().voltage) {
				circuit_error = true;
				Debug.Log ("ERROR !!!!!!!!!!");

			}


			//Debug.Log ("CONNECTING " + gameObject.name + "<---------->" + receiving_node.name);
			//Debug.Log (gameObject.name + "<----VOLTAGE---------->" + gameObject.GetComponent<node>().voltage);
			//Debug.Log (receiving_node.name + "<----VOLTAGE---------->" + receiving_node.GetComponent<node>().voltage);
		}

		else 
		{

			gameObject.GetComponent<MeshRenderer> ().enabled = false;	

		}


	}

}

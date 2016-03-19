using UnityEngine;
using System.Collections;

public class Resistor : MonoBehaviour {

	// Use this for initialization
	public int resistor_node_voltagea = -1;   // open connection
	public int resistor_node_voltageb = -1;   //open connection

	private float resistance ;


	// Initialize the resistance of the resistor
	void Start () {
		resistance = 330;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if((resistor_node_voltagea != -1) && (resistor_node_voltageb != -1  ) )
		{
			if (resistor_node_voltagea > resistor_node_voltageb) 
			{
				float current = (resistor_node_voltagea - resistor_node_voltageb) / resistance;   // current flowing from a ---> b
				
			}
				
		}
	}
}
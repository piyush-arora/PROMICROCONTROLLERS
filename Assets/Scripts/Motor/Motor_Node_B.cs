using UnityEngine;
using System.Collections;

public class Motor_Node_B : MonoBehaviour {

	public GameObject my_motor;
	private Collider Node;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		my_motor.GetComponent<Motor>().voltageB = Node.transform.parent.gameObject.GetComponent<Bread>().voltage;
	}


	void OnTriggerEnter(Collider node)
	{
		//Debug.Log (node.tag);
		if (node.transform.parent.gameObject.tag != "Untagged") 
		{
			Node = node;

		}

		//Led.anode_voltage = node.transform.parent.gameObject.GetComponent<Bread>().voltage;

	}

}

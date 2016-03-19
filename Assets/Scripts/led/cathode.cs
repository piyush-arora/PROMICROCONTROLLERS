using UnityEngine;
using System.Collections;

public class cathode : MonoBehaviour {

	public GameObject my_led;
	private Collider Node;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		my_led.GetComponent<Led>().cathode_voltage = Node.transform.parent.gameObject.GetComponent<Bread>().voltage;
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

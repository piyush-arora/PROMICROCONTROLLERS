using UnityEngine;
using System.Collections;

public class Bread : MonoBehaviour {

	public int voltage ;

	// Use this for initialization
	void Start () {
	
		if (gameObject.tag == "VCC") {
			voltage = 5;
		} else if (gameObject.tag == "GND") {
			voltage = 0;
		} else {
			voltage = -1;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

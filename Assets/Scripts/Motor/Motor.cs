using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {


	public GameObject Motor_Sound;
	private Object Motor_Sound_Object;
	private AudioSource motor_audio_source;
	private bool is_motor_on = true;

	public  int voltageA = -1;
	public  int voltageB = -1;

	Animation clockwise_rotation;

	// Use this for initialization
	void Start () {
		clockwise_rotation = gameObject.GetComponent<Animation> ();
		motor_audio_source = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {


		// check voltage difference
		if ((voltageB - voltageA) == 5 ) 
		{
			clockwise_rotation.enabled = true;

			if(is_motor_on == false)
			{
				motor_audio_source.Play();
				is_motor_on = true;
			}

			//bool data = motor_audio_source.isPlaying; 
			//Debug.Log (data);

		} 
		else 
		{
			clockwise_rotation.enabled = false;
			motor_audio_source.Stop ();
			is_motor_on = false;
		}

	}
}

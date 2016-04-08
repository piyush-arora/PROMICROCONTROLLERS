using UnityEngine;
using System.Collections;

// Must have a Player Motor Script attached to the gameobject
[RequireComponent(typeof(Player_Motor))]
public class Player_Controller : MonoBehaviour {


	[SerializeField]  // show in inspector even after being a private variable
	private float Movement_Speed = 30f; // Movement Speed

	[SerializeField]
	private float Look_Sensitivity = 3f; // Mouse Look Sensitivity

	// To access the functions of the PlayerMotor
	private Player_Motor motor;

	// Initialize
	void Start()
	{
		// no need for gameObject as it is being taken care by the RequireComponent
		motor = GetComponent<Player_Motor> ();
	}

	// Runs EveryTime
	void Update()
	{

		Vector3 position = gameObject.transform.position;

		float mouse_scroll = Input.GetAxis("Mouse ScrollWheel");


		// Get the keyboard Inputs

		// Left and Right Arrow keys
		float _mouse_move_x = Input.GetAxisRaw("Horizontal");
		// Up and Down Arrow keys
		float _mouse_move_y = Input.GetAxis ("Vertical");

		// calculate movement velocity as a 3D vector

		// tranform.right move wrt where we are looking  --> value  (1,0,0)  to  (-1,0,0)
		Vector3 _moveHorizontal = transform.right * _mouse_move_x; 
		// tranform.forward move wrt where we are looking  --> value  (0,0,1)  to  (0,0,-1)
		Vector3 _moveVertical = transform.forward * _mouse_move_y;


		// final movement vector
		Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * Movement_Speed;

		//Apply Rigidbody movement
		motor.move (_velocity);

		// Check If the right hand mouse is down
		if (Input.GetMouseButton (1) == true) {


			// Get the mouse inputs along X axis 
			float _yRot = Input.GetAxisRaw ("Mouse X");

			// calculate rotation as a 3d vector (turnig around) only around Y axis 
			Vector3 _rotation = new Vector3 (0, _yRot, 0) * Look_Sensitivity;
		
			// Apply camera rotation
			motor.rotate (_rotation);


			// Get the mouse inputs along Y axis 
			float _xRot = Input.GetAxisRaw ("Mouse Y");

			// calculate camera rotation as a 3d vector (vertical Looks) NOTE: ONLY CHANGE THE CAMERA NOT THE RIGIDBODY
			Vector3 _camera_rotation = new Vector3 (_xRot, 0, 0) * Look_Sensitivity;

			// Apply camera rotation
			motor.rotateCamera (_camera_rotation);

		//Debug.Log (_camera_rotation);
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



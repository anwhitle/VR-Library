using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	public float baseSpeed = 2.0f; //How fast the player moves
	public float mouseSpeed = 4.0f; //How fast the player looks around
	
	private float verticalRotation = 0.0f;

	public float UDConstraint = 60.0f; //Restricts the head from moving up more than 60 degrees

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;

		// Hide the cursor
		Cursor.visible = false;

	}
	
	// Update is called once per frame
	void Update () {

		Cursor.lockState = CursorLockMode.None;
		Cursor.lockState = CursorLockMode.Locked;

		//Rotation
		float rotateLR = Input.GetAxis ("Mouse X") * mouseSpeed; //Gets mouse movement input
		transform.Rotate (0, rotateLR, 0);

		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSpeed; //Gets mouse movement input
		verticalRotation = Mathf.Clamp (verticalRotation, -UDConstraint, UDConstraint); //variable to restrict followed by the values to restrict it by
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);

		//Movement
		float forwardSpeed = Input.GetAxis ("Vertical") * baseSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * baseSpeed;

		Vector3 speed = new Vector3 (sideSpeed, 0, forwardSpeed); //Left/Right, Up/Down, Forward/Backward

		speed = transform.rotation * speed;

		CharacterController cc = GetComponent<CharacterController> ();
		cc.SimpleMove (speed);
	}
}

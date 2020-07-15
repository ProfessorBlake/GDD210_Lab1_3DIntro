using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
	public float MoveSpeed;
	public float MouseSensitivity;

	private void Update()
	{
		// X/Z Input
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		// Y Input
		float inputY = -0.4f;
		if (Input.GetKey(KeyCode.Space))
			inputY = 0.4f;

		// Add input/movement to position
		transform.position += transform.forward * inputZ * MoveSpeed *Time.deltaTime;
		transform.position += transform.right * inputX * MoveSpeed * Time.deltaTime;
		transform.position += transform.up * inputY * MoveSpeed * Time.deltaTime;

		//Rotation
		float turnInput = Input.GetAxis("Mouse X");
		transform.Rotate(Vector3.up, turnInput * MouseSensitivity * Time.deltaTime,Space.World);
	}

	/*
	 =========  NOTES  ==========
	 Note how the ship moves it's position by multiplying the forward variable in it's transform component by the input and speed. This
	 allows the ship to move relative to the direction it's facing. Whatever direction the ship is facing, it's transform.forward will be a 
	 Vector3 pointing out in front of it.

	 The ship rotates along the up axis IN WORLD SPACE. This means no matter which way the ship is rotated, it will always spin around the Y axis of the scene.
	 */
}

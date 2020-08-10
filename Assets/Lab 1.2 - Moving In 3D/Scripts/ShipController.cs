using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
	public float MoveSpeed;
	public float MouseSensitivity;

	public ParticleSystem[] BigLasers;
	public ParticleSystem[] SmallLasers;

	private void Update()
	{
		// X/Z Input
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		// Y Input
		float inputY = -1f;
		if (Input.GetKey(KeyCode.Space))
			inputY *= -1f;

		//Rotation
		float turnInput = Input.GetAxis("Mouse X");
		transform.Rotate(Vector3.up, turnInput * MouseSensitivity * Time.deltaTime, Space.Self);

		// Add input/movement to position
		transform.position += transform.forward * inputZ * MoveSpeed *Time.deltaTime;
		transform.position += transform.right * inputX * MoveSpeed * Time.deltaTime;
		transform.position += transform.up * inputY * MoveSpeed * Time.deltaTime * 0.25f;

		//Big lasers
		if(Input.GetMouseButtonDown(0))
		{
			for(int i = 0; i < BigLasers.Length; i++)
			{
				BigLasers[i].Play();
			}
		}
		else if(Input.GetMouseButtonUp(0))
		{
			for (int i = 0; i < BigLasers.Length; i++)
			{
				BigLasers[i].Stop();
			}
		}

		//Small lasers
		if (Input.GetMouseButtonDown(1))
		{
			for (int i = 0; i < SmallLasers.Length; i++)
			{
				SmallLasers[i].Play();
			}
		}
		else if (Input.GetMouseButtonUp(1))
		{
			for (int i = 0; i < SmallLasers.Length; i++)
			{
				SmallLasers[i].Stop();
			}
		}
	}

	/*
	 =========  NOTES  ==========
	 Note how the ship moves it's position by multiplying the forward variable in it's transform component by the input and speed. This
	 allows the ship to move relative to the direction it's facing. Whatever direction the ship is facing, it's transform.forward will be a 
	 Vector3 pointing out in front of it.

	 The ship rotates along the up axis IN WORLD SPACE. This means no matter which way the ship is rotated, it will always spin around the Y axis of the scene.
	 */
}

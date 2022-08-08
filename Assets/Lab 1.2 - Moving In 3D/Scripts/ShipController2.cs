using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController2 : MonoBehaviour
{
	public float MoveSpeed;
	public float MouseSensitivity;

	public ParticleSystem[] BigLasers;
	public ParticleSystem[] SmallLasers;

	public Transform cam;

	private void Update()
	{
		// X/Z Input
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		//Rotation
		transform.Rotate(transform.forward, Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime, Space.World);
		transform.Rotate(transform.right, Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime, Space.World);

		// Add input/movement to position
		transform.position += transform.forward * inputZ * MoveSpeed *Time.deltaTime;
		transform.position += transform.right * inputX * MoveSpeed * Time.deltaTime;

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

	private void LateUpdate()
	{
		cam.position = Vector3.Lerp(cam.position, transform.position + Vector3.up * 10 + transform.forward * -10, Time.deltaTime * 20);
		cam.LookAt(transform.position);
	}
}

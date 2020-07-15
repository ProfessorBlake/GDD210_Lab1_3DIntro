using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
	public bool EngineOn = false;
	public Rigidbody RocketRB;
	public float Thrust;
	public ParticleSystem Flames;

	private void Update()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			EngineOn = true;
			Flames.Play();
		}
		else
		{
			Flames.Stop();
			EngineOn = false;
		}
	}

	private void FixedUpdate()
	{
		if(EngineOn)
		{
			RocketRB.AddForce(new Vector3(0f, Thrust, 0f), ForceMode.Acceleration);
		}
	}
}

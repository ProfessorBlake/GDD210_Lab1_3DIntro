using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public Rigidbody BallRB;
	public float Power;

	private void OnMouseDown()
	{
		BallRB.AddForce(Vector3.up * Power, ForceMode.VelocityChange);
	}
}

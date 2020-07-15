using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
	public Rigidbody SpinnerRB;
	public float JumpPower;
	public float SpinPower;

	private void OnMouseDown()
	{
		SpinnerRB.AddForce(new Vector3(0f, Random.Range(JumpPower * 0.9f, JumpPower * 1.1f), 0f));
		SpinnerRB.AddTorque(new Vector3(0f, Random.Range(SpinPower * 0.5f,SpinPower * 1.5f), 0f));
	}
}

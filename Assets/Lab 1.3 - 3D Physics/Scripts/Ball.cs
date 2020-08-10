using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
	public Rigidbody BallRB;
	public float Power;
	public Text BallText;

	private int count = 0;

	private void OnMouseDown()
	{
		BallRB.AddForce(Vector3.up * Power, ForceMode.VelocityChange);
		count++;
		BallText.text = count.ToString();
	}

	private void OnCollisionEnter(Collision collision)
	{
		count = 0;
		BallText.text = count.ToString();
	}

	private void OnTriggerStay(Collider other)
	{
		count = 0;
		BallText.text = "TOO HIGH!";
	}
}

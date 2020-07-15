using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBall : MonoBehaviour
{
	public Rigidbody BallRB;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
			{
				BallRB.AddExplosionForce(500f, hit.point - Vector3.up, 5f);
			}
		}
	}

	private void FixedUpdate()
	{
		if(Mathf.Abs(BallRB.position.x) > 5.15f)
		{
			BallRB.MovePosition(new Vector3(5.15f * -Mathf.Sign(BallRB.position.x), BallRB.position.y, BallRB.position.z));
		}
		if (Mathf.Abs(BallRB.position.z) > 5.15f)
		{
			BallRB.MovePosition(new Vector3(BallRB.position.x, BallRB.position.y, 5.15f * -Mathf.Sign(BallRB.position.z)));
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBall : MonoBehaviour
{
	[SerializeField] private float wrapDistance;

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
		if(Mathf.Abs(BallRB.position.x) > wrapDistance)
		{
			BallRB.MovePosition(new Vector3(wrapDistance * -Mathf.Sign(BallRB.position.x), BallRB.position.y, BallRB.position.z));
		}
		if (Mathf.Abs(BallRB.position.z) > wrapDistance)
		{
			BallRB.MovePosition(new Vector3(BallRB.position.x, BallRB.position.y, wrapDistance * -Mathf.Sign(BallRB.position.z)));
		}
	}
}

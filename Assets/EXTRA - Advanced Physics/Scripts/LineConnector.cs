using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConnector : MonoBehaviour
{
	public List<Transform> Connections;
	public LineRenderer Line;

	private void FixedUpdate()
	{
		Vector3[] positions = new Vector3[Connections.Count];
		for(int i = 0; i < Connections.Count; i++)
		{
			positions[i] = Connections[i].position;
		}

		Line.SetPositions(positions);
	}
}

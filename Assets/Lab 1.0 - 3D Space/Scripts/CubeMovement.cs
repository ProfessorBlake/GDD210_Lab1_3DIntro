using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMovement : MonoBehaviour
{
	public Text CubeInfoText;

	private void Update()
	{
		// Move along a sin wave in each direction, at different speeds.
		// Mathf.Sin(Time.time) will return a float that oscillates between +1 and -1
		transform.position = new Vector3( Mathf.Sin(Time.time * 2f), Mathf.Sin(Time.time * 0.5f), Mathf.Sin(Time.time * 1f));

		//Text
		string xPos = "<color=red>X: " + string.Format("{0:0.00}", Mathf.Round(transform.position.x * 100f) / 100f) + " </color>\n";
		string yPos = "<color=green>Y: " + string.Format("{0:0.00}", Mathf.Round(transform.position.y * 100f) / 100f) + " </color>\n";
		string zPos = "<color=blue>Z: " + string.Format("{0:0.00}", Mathf.Round(transform.position.z * 100f) / 100f) + " </color>";
		CubeInfoText.text = xPos + yPos + zPos;
	}

	private void OnDrawGizmos()
	{
		//Be sure to toggle on Gizmo drawing in your editor/game views in Unity.

		//Axis lines
		Gizmos.color = Color.red;
		Gizmos.DrawLine(new Vector3(-10f, 0f, 0f), new Vector3(10f, 0f, 0f));
		Gizmos.color = Color.green;
		Gizmos.DrawLine(new Vector3(0, -10f, 0f), new Vector3(0, 10f, 0f));
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(new Vector3(0f, 0f, -10f), new Vector3(0f, 0f, 10f));

		//End Points
		Gizmos.color = Color.red;
		Gizmos.DrawCube(new Vector3(-2f, 0f, 0f), Vector3.one * Mathf.Max(0.1f, -transform.position.x * 0.2f));
		Gizmos.DrawCube(new Vector3(2f, 0f, 0f), Vector3.one * Mathf.Max(0.1f, transform.position.x * 0.2f));
		Gizmos.color = Color.green;
		Gizmos.DrawCube(new Vector3(0f, -2f, 0f), Vector3.one * Mathf.Max(0.1f, -transform.position.y * 0.2f));
		Gizmos.DrawCube(new Vector3(0f, 2f, 0f), Vector3.one * Mathf.Max(0.1f, transform.position.y * 0.2f));
		Gizmos.color = Color.blue;
		Gizmos.DrawCube(new Vector3(0f, 0f, -2f), Vector3.one * Mathf.Max(0.1f, -transform.position.z * 0.2f));
		Gizmos.DrawCube(new Vector3(0f, 0f, 2f), Vector3.one * Mathf.Max(0.1f, transform.position.z * 0.2f));

		
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(new Vector3(transform.position.x, -0.5f, 0f), new Vector3(transform.position.x, 0.5f, 0f));
		Gizmos.color = Color.green;
		Gizmos.DrawLine(new Vector3(0, transform.position.y, -0.5f), new Vector3(0, transform.position.y, 0.5f));
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(new Vector3(-0.5f, 0f, transform.position.z), new Vector3(0.5f, 0f, transform.position.z));
	}
}

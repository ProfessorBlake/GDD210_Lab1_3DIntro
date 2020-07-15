using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMovement : MonoBehaviour
{
	public Text CubeInfoText;

	private void Update()
	{
		transform.position = new Vector3(Mathf.Sin(Time.time), Mathf.Sin(Time.time*0.2f), Mathf.Sin(Time.time*0.5f)); //Move x/y/z


		string xPos = "<color=red>X: " + string.Format("{0:0.00}",Mathf.Round(transform.position.x*100f)/100f) + " </color>\n";
		string yPos = "<color=green>Y: " + string.Format("{0:0.00}", Mathf.Round(transform.position.y * 100f) / 100f) + " </color>\n";
		string zPos = "<color=blue>Z: " + string.Format("{0:0.00}", Mathf.Round(transform.position.z * 100f) / 100f) + " </color>";
		CubeInfoText.text = xPos + yPos + zPos;
	}

	private void OnDrawGizmos()
	{
		//Be sure to toggle on Gizmo drawing in your editor/game views in Unity.
		Gizmos.color = Color.red;
		Gizmos.DrawLine(new Vector3(-10f, 0f, 0f), new Vector3(10f, 0f, 0f));
		Gizmos.color = Color.green;
		Gizmos.DrawLine(new Vector3(0, -10f, 0f), new Vector3(0, 10f, 0f));
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(new Vector3(0f, 0f, -10f), new Vector3(0f, 0f, 10f));
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSpin : MonoBehaviour
{
	public float Xspin;
	public float Yspin;
	public float Zspin;

	private void Update()
	{
		if (Input.GetKey(KeyCode.X))
		{
			transform.Rotate(new Vector3(Xspin, 0f, 0f) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.Y))
		{
			transform.Rotate(new Vector3(0f, Yspin, 0f) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.Z))
		{
			transform.Rotate(new Vector3(0f, 0f, Zspin) * Time.deltaTime);
		}
		

		if(Input.GetKey(KeyCode.Space)) //Snap back to identity rotation.
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, Time.deltaTime * 2f);
		}
	}
}

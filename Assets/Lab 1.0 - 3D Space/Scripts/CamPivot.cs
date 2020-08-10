using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPivot : MonoBehaviour
{
	public float Speed = 1f;

    void LateUpdate()
    {
		transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * Speed);
    }
}

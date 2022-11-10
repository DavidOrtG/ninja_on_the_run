using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
	public float RotSpeed = 100f;
	
	void Update()
	{
		//Update rotation
		transform.rotation *= Quaternion.Euler(RotSpeed * Time.deltaTime * Vector3.up.x,
												RotSpeed * Time.deltaTime * Vector3.up.y,
												RotSpeed * Time.deltaTime * Vector3.up.z);
	}
}

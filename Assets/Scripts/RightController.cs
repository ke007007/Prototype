using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightController : MonoBehaviour
{
	RaycastHit hit;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = new Ray (transform.position, transform.forward);
		if (Physics.Raycast (ray, out hit)) {
			print (hit.collider.name); 
		}

	}
}

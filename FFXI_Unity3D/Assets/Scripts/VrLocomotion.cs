using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrLocomotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (OVRInput.Get (OVRInput.Button.PrimaryThumbstickUp))
			transform.Translate (Vector3.forward * 5 * Time.deltaTime);
	}
}

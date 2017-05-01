using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour {
	public Animator anim;


	// START:
	void Start () {
		
	}


	// UPDATE:
	void Update () {
		
	}


	// ON COLLISION ENTER:
	void OnCollisionEnter(){
		anim.SetBool ("sampleBool", true);
	}
}
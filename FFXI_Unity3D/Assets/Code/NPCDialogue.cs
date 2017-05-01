using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour {
	public GameObject canvas;


	// START:
	void Start () { }


	// UPDATE:
	void Update () { }


	// ON TRIGGER ENTER:
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			canvas.SetActive(true);
		}
	}


	// ON TRIGGER EXIT:
	void OnTriggerExit() {
		canvas.SetActive(false);
	}
}
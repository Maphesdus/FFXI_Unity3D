using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questnpc : MonoBehaviour {
	public Texture2D window;
	private Vector2 position = new Vector2(400, 600);
	private Vector2 size = new Vector2(800, 200);
	private bool displayDialogue = false;
	public string text;
	public GUISkin FFXIGuiSkin;

	// START:
	void Start () {	}

		
	// UPDATE:
	void Update () { }


	// ON GUI:
	void OnGUI() {
		GUILayout.BeginArea (new Rect (position.x, position.y, size.x, size.y));

		if (displayDialogue) {
			GUI.DrawTexture (new Rect (0, 0, size.x, size.y), window, ScaleMode.StretchToFill, true, 1);
			GUILayout.Label (text);
		}
		GUILayout.EndArea();
	}


	// ON TRIGGER ENTER:
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			displayDialogue = true;
		}
	}


	// ON TRIGGER EXIT:
	void OnTriggerExit() {
		displayDialogue = false;
	}
}
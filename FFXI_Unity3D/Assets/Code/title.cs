using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour {
    public GUISkin skin;

	private Vector2 screenCenter;
	private Vector2 positionOffset;
	public Vector2 position = new Vector2 (75, 50);
	public Vector2 size = new Vector2 (150, 50);



	// START:
	void Start(){
		screenCenter = new Vector2 (Screen.width / 2, Screen.height / 2);
		positionOffset = new Vector2 (screenCenter.x - position.x, screenCenter.y + position.y);
	}


    // ON GUI:
    void OnGUI() {
        GUI.skin = skin;
		if (GUI.Button(new Rect(positionOffset.x, positionOffset.y, size.x, size.y), "Play")) {
            Debug.Log("Play");
            SceneManager.LoadScene(1);
        } // END IF

		if (GUI.Button(new Rect(positionOffset.x, positionOffset.y + 53, size.x, size.y), "Quit")) {
            Debug.Log("Quit");
            Application.Quit();
        } // END IF
    }
}
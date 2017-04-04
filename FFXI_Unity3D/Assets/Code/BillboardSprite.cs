/// This script comes from the following website:
/// http://www.justinreinhart.com/2016/07/08/pixel-perfect-billboard-sprites/

// BillboardSprite.cs
using UnityEngine;
using System.Collections;

public class BillboardSprite: MonoBehaviour {
	public enum State{AlignToCamera, LookAtCamera};
	private GameObject cam;
	private Transform MyCameraTransform;
	private Transform MyTransform;
	public State AlignmentType;

	// START:
	void Start () {
		cam = GameObject.FindGameObjectWithTag("MainCamera");
		MyTransform = this.transform;
		MyCameraTransform = cam.transform;
	}
	
	// UPDATE:
	void LateUpdate () {
		if (AlignmentType == State.AlignToCamera)
			MyTransform.forward = MyCameraTransform.forward;
		
		else if (AlignmentType == State.LookAtCamera)
			MyTransform.LookAt (MyCameraTransform, Vector3.up);
	}
}
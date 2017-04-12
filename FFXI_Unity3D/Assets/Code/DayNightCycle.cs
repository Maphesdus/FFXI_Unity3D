using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {
	public enum Direction{Up, Down, Left, Right, Forward, Back};
	public Direction direction;
	public float speed = 1.0f;

	// START:
	void Start () {
		
	}

	// UPDATE:
	void Update () {
		if (direction == Direction.Up) this.transform.Rotate ((Vector3.up * speed) * Time.deltaTime);
		else if (direction == Direction.Down) this.transform.Rotate ((Vector3.down * speed) * Time.deltaTime);
		else if (direction == Direction.Left) this.transform.Rotate ((Vector3.left * speed) * Time.deltaTime);
		else if (direction == Direction.Right) this.transform.Rotate ((Vector3.right * speed) * Time.deltaTime);
		else if (direction == Direction.Forward) this.transform.Rotate ((Vector3.forward * speed) * Time.deltaTime);
		else if (direction == Direction.Back) this.transform.Rotate ((Vector3.back * speed) * Time.deltaTime);
	}
}
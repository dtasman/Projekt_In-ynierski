using UnityEngine;
using System.Collections;

public class CubeFloat : MonoBehaviour {

	public float speed, tilt;
	private Vector3 target = new Vector3 (0, 1f, 13);

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
		if (transform.position == target && target.y != -0.1f)
			target.y = -0.1f;
		else if (transform.position == target && target.y == -0.1f)
			target.y = 1f;

		transform.Rotate (Vector3.up * tilt);
	}

}
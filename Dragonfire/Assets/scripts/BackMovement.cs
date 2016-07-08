using UnityEngine;
using System.Collections;

public class BackMovement : MonoBehaviour {
		
	// Use this for initialization
	public float speed =0.5f;

	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}

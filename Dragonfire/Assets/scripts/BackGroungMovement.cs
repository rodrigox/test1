using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	public Vector2 velocity = new Vector2(-4,0);
	void Start () {
	
		GetComponent<Rigidbody2D>().velocity= velocity;
		InvokeRepeating ("CreateObstacle",1f,1.5f);
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}

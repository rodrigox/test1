using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	//public int score=0;
	public GameObject objectStalactites;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle",1f,2f);
	}
	
	// Update is called once per frame
	void Update () {
	


	}
	/*void OnGUI(){
		GUI.color = Color.black;
		GUILayout.Label("Score: " + score.ToString ());
	}*/
	 void CreateObstacle(){
		Instantiate (objectStalactites);

	}


}

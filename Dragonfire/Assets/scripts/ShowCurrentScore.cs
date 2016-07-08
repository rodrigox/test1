using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowCurrentScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("Score").GetComponent<Text>().text =  Score.currentScore.ToString();

    }
}

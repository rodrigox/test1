using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastScore : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //   score = GameObject.Find("");
        GameObject.Find("LastScore").GetComponent<Text>().text = "Score: " + PlayerPrefs.GetFloat("currentScore").ToString();

        GameObject.Find("BestScore").GetComponent<Text>().text = "Best: " + PlayerPrefs.GetFloat("bestScore").ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
}

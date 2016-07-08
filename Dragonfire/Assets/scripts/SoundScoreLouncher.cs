using UnityEngine;
using System.Collections;

public class SoundScoreLouncher : MonoBehaviour {
    AudioSource soundScore;
    float x = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Score.currentScore > x)
        {

            soundScore = GetComponent<AudioSource>();
            soundScore.Play();
            x = Score.currentScore;
        }

    }
}

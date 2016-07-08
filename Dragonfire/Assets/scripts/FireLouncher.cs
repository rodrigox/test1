using UnityEngine;
using System.Collections;

public class FireLouncher : MonoBehaviour {

    float playerPosition;
    Vector2 velocity = new Vector2(10, 0);
    AudioSource fireSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return) ) {

            moveDragom();
        }
        if (Input.touchCount>0) {

            for (int i = 0; i < Input.touchCount; i++) {
                Touch t = Input.GetTouch(i);

                if (t.phase == TouchPhase.Began) { 
                if (Input.GetTouch(i).position.x < Screen.height / 2)
                {
                    moveDragom();

                }

                }
            }
        }
	}

    void moveDragom() {
        //
        playerPosition = GameObject.Find("dragon_0").transform.position.y;
        fireSound = GetComponent<AudioSource>();
        fireSound.Play();
    }
}

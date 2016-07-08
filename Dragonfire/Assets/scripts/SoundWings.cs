using UnityEngine;
using System.Collections;

public class SoundWings : MonoBehaviour
{

    AudioSource wings;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp("space"))
        {
            playWingsSound();
        }

        if (Input.touchCount > 0)
        {

            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch t = Input.GetTouch(i);

                if (t.phase == TouchPhase.Began)
                {
                    if (Input.GetTouch(i).position.x > Screen.height / 2)
                    {

                        playWingsSound();
                    }
                }




            }
        }
    }

    void playWingsSound()
    {
        wings = GetComponent<AudioSource>();
        wings.Play();
    }
}

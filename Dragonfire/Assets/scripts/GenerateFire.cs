using UnityEngine;
using System.Collections;

public class GenerateFire : MonoBehaviour {
  
    public  GameObject fire;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("return")) {
            createFire();
             
        }

        if (Input.touchCount > 0)
        {

            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch t = Input.GetTouch(i);

                if (t.phase == TouchPhase.Began)
                {
                    if (Input.GetTouch(i).position.x < Screen.height / 2)
                    {
                        createFire();

                    }

                }
            }
        }

        if (this.gameObject.transform.position.x > 20)
        {


            DestroyObject(gameObject);
            Debug.Log("Fire Destruido");




        }
    }

    void createFire() {
        float yPosition = GameObject.Find("dragon_0").transform.position.y;
        float xPosition = GameObject.Find("dragon_0").transform.position.x ;
        // this.gameObject.transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);

        //  fire.transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        transform.position = new Vector3(xPosition+ 1.1f, yPosition, 0);
        Instantiate(fire,transform.position,transform.rotation );
        


    }
}

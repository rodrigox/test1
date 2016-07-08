using UnityEngine;
using System.Collections;

public class MandaFogo : MonoBehaviour {
    public Vector2 velocity = new Vector2(10, 0);
    float moveSpeed= 100;
    Vector2 posicao = new Vector2();
    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("return") || (Input.touchCount > 0 && Input.GetTouch(0).position.x < Screen.height / 2 && Input.GetTouch(0).phase == TouchPhase.Began))
        {


            
        }*/

        if (this.gameObject.transform.position.x > 1) {
            Destroy(this.gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D other)
    {
      Destroy(this.gameObject);
    }
}

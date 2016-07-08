using UnityEngine;
//using System.Collections;

public class Obstaculo : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4,0);
    bool validador = true;
	public static float range =0;
    public static float positionY;


    void Start () {
		range = Random.Range (-2,2);
	
		GetComponent<Rigidbody2D>().velocity = velocity;

       positionY = transform.position.y - range;
		transform.position = new Vector3 (transform.position.x,positionY, transform.position.z);
        
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.x<-20){


			DestroyObject(gameObject);
			Debug.Log("Destruido");

           


        }

      /*  double posicao = System.Math.Round(this.gameObject.transform.position.x,2);
        if (posicao == -7) {
            Debug.Log("Entrou no if BRBRR");
        }
        */
        if (Mathf.Round((this.gameObject.transform.position.x)) == -12f/*>-7.0 && this.gameObject.transform.position.x<7.2*/ && validador)
        {
            Score.currentScore++;
         
            float z = this.gameObject.transform.position.x;
            //  score = Mathf.Round(this.gameObject.transform.position.x);
          //  Debug.Log(" entrou no if certo");
            validador = false;
        }


    }

}

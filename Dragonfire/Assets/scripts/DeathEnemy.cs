using UnityEngine;
using System.Collections;

public class DeathEnemy : MonoBehaviour {
    int shootNumber;
   // GameObject explosionAnimation = new GameObject();
    // Use this for initialization
    void Start()
    {
        shootNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        shootNumber++;
        if (shootNumber > 2)
        {
          //  explosionAnimation.transform.position = this.gameObject.transform.position;
          //  Instantiate(explosionAnimation);
            Destroy(gameObject);
            shootNumber = 0;
        }
    }
}

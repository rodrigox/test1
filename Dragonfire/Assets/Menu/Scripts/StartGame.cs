using UnityEngine;
using System.Collections;


public class StartGame : MonoBehaviour
{
    public GameObject score;


    // Update is called once per frame
    public void MudarCena(string cena)
    {

        Application.LoadLevel(cena);
    }

  

    void Update()
    {
        if (Input.touchCount>0) {
            Application.LoadLevel("Project1");
        }
    }
}

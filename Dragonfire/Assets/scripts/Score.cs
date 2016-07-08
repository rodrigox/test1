using UnityEngine;
using System.Collections;

public  class Score : MonoBehaviour {

  public  GameObject rocha;
   static  float score = 0;
   static  public float currentScore = 0;

    static public float bestScore = 0;
   
    bool controle =false;
   
    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        //score= GameObject.Find("ObjectStalactitesBr").transform.position.x;

       


    }
    
    void OnGUI()
    {
        
        GUI.color = Color.green;
        

       
        GUILayout.Label("Score: " + currentScore.ToString());
      
        
        
    }
    
}

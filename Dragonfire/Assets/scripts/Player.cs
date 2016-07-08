using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour 
{
    public GameObject gameObject = new GameObject();
    //public AudioSource lose;
    //public Rigidbody2D rigidbody2D = new Rigidbody2D();
    public Vector2 jumpForce = new Vector2(0,280);
    int touchedJump = 0;
	// Use this for initialization
	/*void Start () {
	
	}*/

	// Update is called once per frame 

	void Start(){
        
        // Limpando ultimo score antes de comecar o jogo
       Score.currentScore = 0;


      
       

	}
	void Update () 
	{
       

        // Se touch
        if (Input.touchCount>0 && Application.loadedLevelName.Equals("Project1"))
        {

            for (int i = 0; i < Input.touchCount; i++) {
                Touch t = Input.GetTouch(i);

                if (t.phase == TouchPhase.Began) {
                    if (Input.GetTouch(i).position.x>Screen.height/2) {
                        velocidadeEForca();

                    }
                }
            }
            #region

            /// <summary>
            /// Codigo para impedir que o animação gire no proprio eixo (five de cabeça pra baixo)
            /// </summary>

            /*

            Vector2 moveDirection = GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            //  Vector2 moveDirection = gameObject.rigidbody2D.velocity;
            if (moveDirection != Vector2.zero)
            {
               
                float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                Debug.Log("Entrou aqui IEnumerator");
            }*/
        }
        #endregion
        // se espaco pressionado
        if (Input.GetKeyDown("space") && Application.loadedLevelName.Equals("Project1")) {
            velocidadeEForca();
        }
			Vector2 screamPosition = Camera.main.WorldToScreenPoint (transform.position);
			if (screamPosition.y > Screen.height || screamPosition.y < 0) {
            saveLastScore();
            saveBestScore();
            Die ();
			//playSoundEffect();

		}


	}










	void OnCollisionEnter2D(Collision2D other){
        saveLastScore();
        saveBestScore();
      //  Score.currentScore = 0;
		Die ();
	}

	void Die(){
       // Score.currentScore = 0;

        Application.LoadLevel ("MenuScene");
       

    }
    //
    void saveLastScore() {

        PlayerPrefs.SetFloat("currentScore", Score.currentScore);
        PlayerPrefs.Save();
        //   string scoreResgatado=  PlayerPrefs.GetFloat("currentScore").ToString();
        //   Debug.LogFormat("Score resgatado Banco",10.ToString());
        // 

    }

    void saveBestScore() {
        if (PlayerPrefs.GetFloat("bestScore") < Score.currentScore)
        {
            Score.bestScore = Score.currentScore;

            PlayerPrefs.SetFloat("bestScore", Score.bestScore);
           
        
            PlayerPrefs.Save();
             Debug.Log("if BestScore " + PlayerPrefs.GetFloat("bestScore").ToString());
        }
    }

	void playSoundEffect(){
       

        /*AudioClip errorSound = Resources.Load("wrong", typeof(AudioClip));
		AudioSource sound = gameObject.GetComponent<AudioSource>();
		sound.Play ();*/
	}




    void velocidadeEForca() {

        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(jumpForce);
    }
	void OnPouse(){

	}
    /// <summary>
    /// Codigo para atualizar o poligonon collider em cada frame da animação 
    /// </summary>
    #region


    public bool iStrigger;
    //public PhysicsMaterial2D _material ;

    private SpriteRenderer spriteRenderer;
    private List<Sprite> spritesList;
    private Dictionary<int, PolygonCollider2D> spriteColliders;
    private bool _processing;

    private int _frame;
    public int Frame
    {
        get { return _frame; }
        set
        {
            if (value != _frame)
            {
                if (value > -1)
                {
                    spriteColliders[_frame].enabled = false;
                    _frame = value;
                    spriteColliders[_frame].enabled = true;
                }
                else {
                    _processing = true;
                    StartCoroutine(AddSpriteCollider(spriteRenderer.sprite));
                }
            }
        }
    }

    private IEnumerator AddSpriteCollider(Sprite sprite)
    {
        spritesList.Add(sprite);
        int index = spritesList.IndexOf(sprite);
        PolygonCollider2D spriteCollider = gameObject.AddComponent<PolygonCollider2D>();
        spriteCollider.isTrigger = iStrigger;
        //    spriteCollider.sharedMaterial = _material;
        spriteColliders.Add(index, spriteCollider);
        yield return new WaitForEndOfFrame();
        Frame = index;
        _processing = false;
       
    }

    private void OnEnable()
    {
        spriteColliders[Frame].enabled = true;
    }

    private void OnDisable()
    {
        spriteColliders[Frame].enabled = false;
    }

    private void Awake()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();

        spritesList = new List<Sprite>();

        spriteColliders = new Dictionary<int, PolygonCollider2D>();

        Frame = spritesList.IndexOf(spriteRenderer.sprite);
        Debug.Log("Atualizou");
    }

    private void LateUpdate()
    {
        if (!_processing)
            Frame = spritesList.IndexOf(spriteRenderer.sprite);
        
    }
    #endregion
}


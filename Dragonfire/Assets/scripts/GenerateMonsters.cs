using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateMonsters : MonoBehaviour {

    // Use this for initialization
    public GameObject[] enemys;
    Random randomSprite = new Random();
  
    int randomMonster;
    void Start () {
        // pega um monstro aleatorio da lista de objetos e joga na tela 
      
      

        InvokeRepeating("generateMonsters", 1f, 2f);
      
    }
	
	// Update is called once per frame
	void Update () {
        randomMonster = Random.Range(0, enemys.Length );
       // Debug.Log("valor do random" + randomMonster);

    }

    void generateMonsters() {
        float yPosition = GameObject.Find("ObjectStalactitesBr").transform.position.y;
       // float xPosition = GameObject.Find("dragon_0").transform.position.x;
        // this.gameObject.transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);

        //  fire.transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        transform.position = new Vector3(16.2f, Obstaculo.positionY, 0);
        //Instantiate(fire, transform.position, transform.rotation);
      //  Debug.Log("Posicao Rochas"+yPosition);

        Instantiate(enemys[randomMonster],transform.position,transform.rotation);
      

    }

    // change collider to each frame
    #region

/*
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

    }*/
    #endregion
}

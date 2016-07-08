using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovementMonster : MonoBehaviour {

    public Vector2 velocity = new Vector2(-4, 0);
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
	
	// Update is called once per frame
	void Update () {

        if (this.gameObject.transform.position.x < -15)
        {


            DestroyObject(gameObject);
            Debug.Log("Destruido Monstro");




        }

    }




    // change collider to each frame
    #region

    
        public bool iStrigger;
        //public PhysicsMaterial2D _material ;

        private SpriteRenderer spriteRenderer;
        private System.Collections.Generic.List<Sprite> spritesList;
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

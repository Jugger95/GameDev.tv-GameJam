using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving_Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    //public ParticleSystem Particle;

    public float MoveSpeed;
    public float MoveUpSpeed;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(MoveSpeed, MoveUpSpeed);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

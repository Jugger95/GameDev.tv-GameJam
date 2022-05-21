using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D con;   
    public Animator anim;
   // public ParticleSystem Particle;
   // public AudioSource JumpSound;
   // public AudioSource KilledSound;
    //public Rigidbody2D rb;
    public CircleCollider2D circle;


    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;
    bool canMove = true;

    void Start()
    {
        //transform.position = new Vector3(0f, -6.34f, 0f);
          
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            anim.SetFloat("Speed", Mathf.Abs(horizontalMove));

            
            if(Input.GetButtonDown("Jump") && jump == false)
            {
                jump = true;
                //JumpSound.Play();
               // anim.SetBool("IsJumping", true);
                crouch = false;
            }

            if(Input.GetKeyDown(KeyCode.S))
            {
                crouch = true;
                transform.localScale = new Vector3(5f, 2.5f, 0f);
                circle.radius = 0.1005106f;

            }

            if(Input.GetKeyUp(KeyCode.S))
            {
                crouch = false;
                transform.localScale = new Vector3(5f, 5f, 0f);
                circle.radius = 0.2010212f;
            }

            if(Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.LoadScene(0);
            }
        }
        
    }

    void FixedUpdate(){
        con.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;     
    }
}

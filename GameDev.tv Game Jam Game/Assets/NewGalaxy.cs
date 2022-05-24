using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGalaxy : MonoBehaviour
{

    public GameObject NewGalaxyStarter;
    public Animator anim2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //anim2.SetBool("isHit", true);
        NewGalaxyStarter.GetComponent<Animator>().SetBool("isHit", true);
    }
}

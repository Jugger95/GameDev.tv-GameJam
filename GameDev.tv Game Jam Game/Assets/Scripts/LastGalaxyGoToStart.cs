using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastGalaxyGoToStart : MonoBehaviour
{

    public int GoToStartSceneNumber = 4;
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
        if(coll.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(GoToStartSceneNumber);
        }
    }
}

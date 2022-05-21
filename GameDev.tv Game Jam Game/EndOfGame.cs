using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGame : MonoBehaviour
{

    public int EndOfGameBuildNumber;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {
            SceneManagement.LoadScene(EndOfGameBuildNumber);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public int GotoScene;
    public void Galaxy1()
    {
        SceneManager.LoadScene(GotoScene);
    }

    public void HowTo()
    {
        SceneManager.LoadScene(1);
    }

    public void Story()
    {
        SceneManager.LoadScene(2);
    }
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}

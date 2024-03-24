using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("FirstGame");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
        

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeCont : MonoBehaviour
{

    public void ChangeCont(string scene)
    {
        SceneManager.LoadScene("About");
    }
}


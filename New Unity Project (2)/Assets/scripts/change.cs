using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour {

    public void ChangeScene2(string scene)
    {
        SceneManager.LoadScene("SampleScene");
    }

    public static void ChangeScene(string scene){
        SceneManager.LoadScene(scene);
    }
}

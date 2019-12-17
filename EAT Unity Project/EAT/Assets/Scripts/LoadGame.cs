using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void loadScene() //string name
    {
       SceneManager.LoadScene("Level1");
        //SceneManager.LoadScene(name);
    }
}

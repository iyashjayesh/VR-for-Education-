using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class csnBtn : MonoBehaviour
{
    public void changeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp(){
        Application.Quit();
    }
}

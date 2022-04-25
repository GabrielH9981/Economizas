using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public void LoadScenes(string scene){
        SceneManager.LoadScene(scene);
    }

    public void LoadingScreens(){
        
        LoadScenes(PlayerPrefs.GetString("Cena"));
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadingScreens", 1.5f);
    }
}

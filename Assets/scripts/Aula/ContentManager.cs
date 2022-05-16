using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentManager : MonoBehaviour
{
    
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;

    void Start()
    {
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        button6.interactable = false;

        if (PlayerPrefs.GetString("Aula1") == "true"){
            button2.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

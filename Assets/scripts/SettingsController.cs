using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    
    public InputField newName;
    private string name;

    public void ChangeName(InputField newName){
        PlayerPrefs.SetString("playerName", newName.text);
    }

    void Start()
    {
        name = PlayerPrefs.GetString("playerName", newName.text);
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

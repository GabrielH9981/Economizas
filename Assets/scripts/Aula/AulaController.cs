using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaController : MonoBehaviour
{
    
    public GameObject buttonFinish;
    public GameObject buttonRepeat;
    public GameObject buttonBack;

    public void FinishAula(){
        buttonFinish.SetActive(true);
        buttonRepeat.SetActive(true);
    }

    public void interruptAula(){
        buttonBack.SetActive(true);
    }

    public void resumeAula(){
        buttonBack.SetActive(false);
    }

    public void CheckAula(){
        PlayerPrefs.SetString("Aula1", "true");
    }

    void Start()
    {
        buttonFinish.SetActive(false);
        buttonRepeat.SetActive(false);
        buttonBack.SetActive(false);

        Invoke("FinishAula", 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

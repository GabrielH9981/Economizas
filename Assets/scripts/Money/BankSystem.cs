using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankSystem : MonoBehaviour
{
    public int money;
    
    void Start()
    {
        money = PlayerPrefs.GetInt("bankValue", (int)money);
    }

    void Update()
    {
        PlayerPrefs.SetInt("bankValue", (int)money);
        //Debug.Log("Money value:" + money);
    }

    public void ConsultMoney(){
        money = PlayerPrefs.GetInt("bankValue", (int)money);
    }

    public void testeMoney(){
        money += 100;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySistem : MonoBehaviour
{
    public int money;
    
    void Start()
    {
        money = PlayerPrefs.GetInt("moneyValue", (int)money);
    }

    void Update()
    {
        PlayerPrefs.SetInt("moneyValue", (int)money);
        //Debug.Log("Money value:" + money);
    }

    public void ConsultMoney(){
        money = PlayerPrefs.GetInt("moneyValue", (int)money);
    }

    private void OnTriggerEnter2D(Collider2D objCollider) {
        if (objCollider.name == "CashMachine"){
            money += 100;
        }
    }
}

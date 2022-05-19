using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySistem : MonoBehaviour
{
    public int money;
    public int moneyBank;
    public int moneyInvested;
    
    void Start()
    {
        money = PlayerPrefs.GetInt("moneyValue", (int)money);
        moneyBank = PlayerPrefs.GetInt("bankValue", (int)moneyBank);
        moneyInvested = PlayerPrefs.GetInt("investValue", (int)moneyInvested);
    }

    void Update()
    {

    }

    public void Investir(){
        if (money >= 100){
            money -= 100;
            PlayerPrefs.SetInt("moneyValue", (int)money);
            moneyInvested +=100;
            PlayerPrefs.SetInt("investValue", (int)moneyInvested);
        }
    }

    public void Sacar(){
        if (moneyBank >= 100){
            money += 100;
            PlayerPrefs.SetInt("moneyValue", (int)money);
            moneyBank -=100;
            PlayerPrefs.SetInt("bankValue", (int)moneyBank);
        }
    }

    public void SacarInvestimento(){
        if (moneyInvested >= 100){
            money += 100;
            PlayerPrefs.SetInt("moneyValue", (int)money);
            moneyInvested -=100;
            PlayerPrefs.SetInt("investValue", (int)moneyInvested);
        }
    }

    public void testeMoney(){
        money = 200;
        PlayerPrefs.SetInt("moneyValue", (int)money);
        moneyBank = 200;
        PlayerPrefs.SetInt("bankValue", (int)moneyBank);
    }

    public void Depositar(){
        if (money >= 100){
            money -= 100;
            PlayerPrefs.SetInt("moneyValue", (int)money);
            moneyBank +=100;
            PlayerPrefs.SetInt("bankValue", (int)moneyBank);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySistem : MonoBehaviour
{
    public int money;
    public int moneyBank;
    public int moneyInvested;
    public int divida;
    public int emprestimoDisponivel = 100;
    public Button buttonEmprestar;
    public Button buttonPagar;
    
    void Start()
    {
        money = PlayerPrefs.GetInt("moneyValue", (int)money);
        moneyBank = PlayerPrefs.GetInt("bankValue", (int)moneyBank);
        moneyInvested = PlayerPrefs.GetInt("investValue", (int)moneyInvested);
        divida = PlayerPrefs.GetInt("dividaValue", (int)divida);
        emprestimoDisponivel = PlayerPrefs.GetInt("emprestimoValue", (int)emprestimoDisponivel);

        if (divida > 0){
            buttonEmprestar.interactable = false;
            buttonPagar.interactable = true;
        }else{
            buttonEmprestar.interactable = true;
            buttonPagar.interactable = false;
        }
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
        money += 50000;
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

    public void Emprestar(){
        emprestimoDisponivel = 0;
        PlayerPrefs.SetInt("emprestimoValue", (int)emprestimoDisponivel);
        money += 100;
        PlayerPrefs.SetInt("moneyValue", (int)money);
        divida += 100;
        PlayerPrefs.SetInt("dividaValue", (int)divida);
        buttonEmprestar.interactable = false;
        buttonPagar.interactable = true;
    }

    public void Pagar(){
        if (money >= 100){
            emprestimoDisponivel = 100;
            PlayerPrefs.SetInt("emprestimoValue", (int)emprestimoDisponivel);
            money -=100;
            PlayerPrefs.SetInt("moneyValue", (int)money);
            divida -=100;
            PlayerPrefs.SetInt("dividaValue", (int)divida);
            buttonEmprestar.interactable = true;
            buttonPagar.interactable = false;
        }else{
            Debug.Log("NÃO TEM DINHEIRO PRA PAGAR - FAZER POP UP DPS");
        }
    }
}

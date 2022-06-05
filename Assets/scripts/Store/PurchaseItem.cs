using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseItem : MonoBehaviour
{   
    public Text priceAlien;
    public Text priceCartola;
    public Text priceFaixa;
    public Text priceGhost;
    public Text priceMask;
    public Text pricePirata;
    public Text priceViking;
    public Text priceWitcher;

    public Text buttonAlien;
    public Text buttonCartola;
    public Text buttonFaixa;
    public Text buttonGhost;
    public Text buttonMask;
    public Text buttonPirata;
    public Text buttonViking;
    public Text buttonWitcher;

    private int money;
    public string selectedPlayer;

    public void ResetFunction(){
        PlayerPrefs.SetString("priceConfig", "Não Configurado");
        PlayerPrefs.SetString("selectedPlayer", "basePlayer");
    }

    public void ChoseAlien(){
        if (PlayerPrefs.GetString("buttonAlien") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 5000;
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("priceAlien", "OBTIDO");
            PlayerPrefs.SetString("buttonAlien", "Selecionar");
        }
        selectedPlayer = "alienPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }
    public void ChoseCartola(){
        if (PlayerPrefs.GetString("buttonCartola") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 200;
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("priceCartola", "OBTIDO");
            PlayerPrefs.SetString("buttonCartola", "Selecionar");
        }
        selectedPlayer = "cartolaPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }
    public void ChoseFaixa(){
        if (PlayerPrefs.GetString("buttonFaixa") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 400;
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("priceFaixa", "OBTIDO");
            PlayerPrefs.SetString("buttonFaixa", "Selecionar");
        }
        selectedPlayer = "faixaPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }
    public void ChoseGhost(){
        if (PlayerPrefs.GetString("buttonGhost") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 3000;  
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("priceGhost", "OBTIDO");
            PlayerPrefs.SetString("buttonGhost", "Selecionar");
        }
        selectedPlayer = "ghostPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }
    public void ChoseMask(){
        if (PlayerPrefs.GetString("buttonMask") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 1000;
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("priceMask", "OBTIDO");
            PlayerPrefs.SetString("buttonMask", "Selecionar");
        }
        selectedPlayer = "maskPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }
    public void ChosePirata(){
        if (PlayerPrefs.GetString("buttonPirata") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 1500;
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("pricePirata", "OBTIDO");
            PlayerPrefs.SetString("buttonPirata", "Selecionar");
        }
        selectedPlayer = "pirataPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }
    public void ChoseViking(){
        if (PlayerPrefs.GetString("buttonViking") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 2000;
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("priceViking", "OBTIDO");
            PlayerPrefs.SetString("buttonViking", "Selecionar");
        }
        selectedPlayer = "vikingPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }
    public void ChoseWitcher(){
        if (PlayerPrefs.GetString("buttonWitcher") == "Comprar"){
            money = PlayerPrefs.GetInt("moneyValue", (int)money);
            money -= 500;
            PlayerPrefs.SetInt("moneyValue", (int)money);

            PlayerPrefs.SetString("priceWitcher", "OBTIDO");
            PlayerPrefs.SetString("buttonWitcher", "Selecionar");
        }
        selectedPlayer = "witcherPlayer";
        PlayerPrefs.SetString("selectedPlayer", selectedPlayer);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        priceAlien.text = PlayerPrefs.GetString("priceAlien");
        priceCartola.text = PlayerPrefs.GetString("priceCartola");
        priceFaixa.text = PlayerPrefs.GetString("priceFaixa");
        priceGhost.text = PlayerPrefs.GetString("priceGhost");
        priceMask.text = PlayerPrefs.GetString("priceMask");
        pricePirata.text = PlayerPrefs.GetString("pricePirata");
        priceViking.text = PlayerPrefs.GetString("priceViking");
        priceWitcher.text = PlayerPrefs.GetString("priceWitcher");

        buttonAlien.text = PlayerPrefs.GetString("buttonAlien");
        buttonCartola.text = PlayerPrefs.GetString("buttonCartola");
        buttonFaixa.text = PlayerPrefs.GetString("buttonFaixa");
        buttonGhost.text = PlayerPrefs.GetString("buttonGhost");
        buttonMask.text = PlayerPrefs.GetString("buttonMask");
        buttonPirata.text = PlayerPrefs.GetString("buttonPirata");
        buttonViking.text = PlayerPrefs.GetString("buttonViking");
        buttonWitcher.text = PlayerPrefs.GetString("buttonWitcher");
    }
}

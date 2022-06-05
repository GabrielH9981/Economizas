using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurePrices : MonoBehaviour
{
    private bool aux = true;
    private string configurado;

    void Start()
    {
        
        configurado = PlayerPrefs.GetString("priceConfig");
        Debug.Log(configurado);

        if (aux == true && configurado != "Configurado"){
            PlayerPrefs.SetString("priceAlien", "5000");
            PlayerPrefs.SetString("priceCartola", "200");
            PlayerPrefs.SetString("priceFaixa", "400");
            PlayerPrefs.SetString("priceGhost", "3000");
            PlayerPrefs.SetString("priceMask", "1000");
            PlayerPrefs.SetString("pricePirata", "1500");
            PlayerPrefs.SetString("priceViking", "2000");
            PlayerPrefs.SetString("priceWitcher", "500");

            PlayerPrefs.SetString("buttonAlien", "Comprar");
            PlayerPrefs.SetString("buttonCartola", "Comprar");
            PlayerPrefs.SetString("buttonFaixa", "Comprar");
            PlayerPrefs.SetString("buttonGhost", "Comprar");
            PlayerPrefs.SetString("buttonMask", "Comprar");
            PlayerPrefs.SetString("buttonPirata", "Comprar");
            PlayerPrefs.SetString("buttonViking", "Comprar");
            PlayerPrefs.SetString("buttonWitcher", "Comprar");

            PlayerPrefs.SetString("priceConfig", "Configurado");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

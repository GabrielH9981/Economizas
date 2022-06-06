using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuadrosController : MonoBehaviour
{
    //troca image file
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    string[] nomeQuadros = new string[6]{"Jinx Cheia de Ódio", "Pikachu bala", "Controle", "Controle 2", "Yoshi", "Maçazinha"};
    string[] priceQuadros = new string[6]{"$50.000", "$25.500", "$20.000", "$11.000", "$10.000", "$5.000"};
    string[] compradores = new string[6]{"0", "0", "0", "0", "0", "0"};
    int[] priceCompra = new int[6]{50000, 25500, 20000, 11000, 10000, 5000};

    public Text textName;
    public Text textPrice;
    public Text textLance;
    public Button buttonLance;

    private int money;

    public int numQuadro = 1;

    private string _caminho;

    public void ImageChange(){
        textName.text = nomeQuadros[numQuadro].ToString();
        textPrice.text = priceQuadros[numQuadro].ToString();
        textLance.text = compradores[numQuadro].ToString();

        if (compradores[numQuadro] == "0"){
            buttonLance.interactable = true;
        }else{
            buttonLance.interactable = false;
        }

        spriteRenderer.sprite = spriteArray[numQuadro];
        numQuadro +=1;
        if (numQuadro == 6){
            numQuadro = 0;
        }
    }

    public void LanceQuadro(){
        money = PlayerPrefs.GetInt("moneyValue", (int)money);

        if (money >= priceCompra[numQuadro-1]){
            money -= priceCompra[numQuadro-1];
            PlayerPrefs.SetInt("moneyValue", (int)money);

            string name = PlayerPrefs.GetString("playerName");
            compradores[numQuadro-1] = name;
            textLance.text = compradores[numQuadro-1].ToString();

            Debug.Log(compradores[numQuadro-1]);
            Debug.Log("kakak : "+ name);
            buttonLance.interactable = false;
        }
        
    }

    void Start()
    {
        numQuadro = 0;
        ImageChange();
    }

    void Update()
    {

    }
}

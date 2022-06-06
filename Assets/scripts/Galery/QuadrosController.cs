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

    public Text textName;
    public Text textPrice;

    public int numQuadro = 1;

    private string _caminho;

    public void ImageChange(){
        textName.text = nomeQuadros[numQuadro].ToString();
        textPrice.text = priceQuadros[numQuadro].ToString();

        spriteRenderer.sprite = spriteArray[numQuadro];
        numQuadro +=1;
        if (numQuadro == 6){
            numQuadro = 0;
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

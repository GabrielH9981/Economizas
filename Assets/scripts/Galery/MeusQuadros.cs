using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MeusQuadros : MonoBehaviour
{
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    string[] nomeQuadros = new string[3]{"teste", "blablabla", "eu n aguento mais"};

    public Text textName;
    public int numQuadro = 1;

    public void ImageChange(){
        textName.text = nomeQuadros[numQuadro].ToString();

        spriteRenderer.sprite = spriteArray[numQuadro];
        numQuadro +=1;
        if (numQuadro == 3){
            numQuadro = 0;
        }
    }

    void Start()
    {
        numQuadro = 0;
        ImageChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

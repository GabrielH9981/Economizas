using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ChangeImage : MonoBehaviour
{
    //troca image file
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;


    //public GameObject objeto;
    //public Transform destino;

    int numArquivos = 0;
    int numQuadro = 0;

    public void ImageChange(int numQuadro){
        spriteRenderer.sprite = spriteArray[0];

        if (numQuadro >= numArquivos){
            numQuadro = 0;
        }else{
            numQuadro+=1;
        }
    }

    void Start()
    {
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        string[] arquivos = Directory.GetFiles("D:\\projetos unity\\Economizas\\Assets\\quadros", "*png", SearchOption.AllDirectories);
        foreach (string arq in arquivos){
            Debug.Log("nome arq: " + arq);
            numArquivos+=1;
            spriteArray = Resources.LoadAll<Sprite>("alinebobona");
            //Instantiate(objeto,destino.position,destino.rotation);
        }
        Debug.Log("Num arquivos: " + numArquivos);

//----------------------------------------------------------------------------------------------------------------------------------------\\
        //troca image file
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        ImageChange(numQuadro);
    }
}

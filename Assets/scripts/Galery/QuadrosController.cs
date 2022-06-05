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
    string[] nomeQuadros;

    int numArquivos = 0;
    int numQuadro = 1;

    private string _caminho;

    public void ImageChange(int numArquivos){
        numQuadro = PlayerPrefs.GetInt("numQuadro", (int)numQuadro);
        numArquivos = PlayerPrefs.GetInt("numArquivos", (int)numArquivos);

        spriteRenderer.sprite = spriteArray[numQuadro];
        Debug.Log("olha o num fdp>>> " + numQuadro);
        Debug.Log("olha o num fdpp>>> " + numArquivos);

        if (numQuadro <= (numArquivos - 2)){
            numQuadro +=1;
            PlayerPrefs.SetInt("numQuadro", (int)numQuadro);
            Debug.Log("entrou no if");
        }else{
            numQuadro=0;
            PlayerPrefs.SetInt("numQuadro", (int)numQuadro);
            Debug.Log("entrou no else " + numQuadro);
        }
    }

    void Start()
    {
        numQuadro = 0;
        PlayerPrefs.SetInt("numQuadro", (int)numQuadro);
        _caminho = Application.dataPath + "/files/";

        string[] arquivos = Directory.GetFiles(_caminho, "*png", SearchOption.AllDirectories);
        string auxNome = "a";

        List<string> list = new List<string>();

        foreach (string arq in arquivos){
            
            //remove as parada desnecessária pra ficar só o nome do arquivo sem a extensão
            auxNome = arq.Remove(0, 44);
            auxNome = auxNome.Remove(auxNome.Length - 4);

            list.Add(auxNome);

            numArquivos+=1;
            PlayerPrefs.SetInt("numArquivos", (int)numArquivos);
            spriteArray = Resources.LoadAll<Sprite>("");
            //Instantiate(objeto,destino.position,destino.rotation);
        }

        nomeQuadros = list.ToArray();
        Debug.Log("Num arquivos: " + numArquivos);

        
    }

    void Update()
    {

    }
}

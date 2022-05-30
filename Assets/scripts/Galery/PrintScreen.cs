using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScreen : MonoBehaviour {

    public GameObject buttonFinish;
    public GameObject buttonCancel;
    public GameObject palletColor;
    public GameObject PainelQuadro;
    public InputField nomeQuadro;

   [Tooltip("Nome para o arquivo de imagem.")]
   public string nomeImagem; //A imagem fica armazenada por padrão na pasta raiz do projeto, visível pelo Windows Explorer.
   [Tooltip("Qualidade da print, 1 médio 4 em diante alta qualidade(impressão).")]
   public int qualidade = 1;

    public void Start(){
       CancelAction();
    }

    public void GetInputOnClickHandler(){
        Debug.Log("é o pijas: " + nomeQuadro.text);
    }

    public void FinishArt(){
       PainelQuadro.SetActive(true);
    }

    public void CancelAction(){
        PainelQuadro.SetActive(false);
    }

    public void ConfirmAction(){
        nomeImagem = nomeQuadro.text;
        CaptureImage(nomeImagem);
    }

    public void CaptureImage(string nomeImagem){
        buttonFinish.SetActive(false);
        buttonCancel.SetActive(false);
        palletColor.SetActive(false);
        PainelQuadro.SetActive(false);
        ScreenCapture.CaptureScreenshot("Assets/quadros/" + nomeImagem + ".png", 1);
        ScreenCapture.CaptureScreenshot("Assets/" + nomeImagem + ".png", 1);
        ScreenCapture.CaptureScreenshot(nomeImagem + ".png", 1);
    }
}
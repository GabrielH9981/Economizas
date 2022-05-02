using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintScreen : MonoBehaviour {

   [Tooltip("Nome para o arquivo de imagem.")]
   public string nomeImagem; //A imagem fica armazenada por padrão na pasta raiz do projeto, visível pelo Windows Explorer.
   [Tooltip("Qualidade da print, 1 médio 4 em diante alta qualidade(impressão).")]
   public int qualidade = 1;

    public void CaptureImage(string nomeImagem){
        ScreenCapture.CaptureScreenshot(nomeImagem+".png", 1);
    }
}
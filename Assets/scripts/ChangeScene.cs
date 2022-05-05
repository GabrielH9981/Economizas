using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScenes(string scene){
        SceneManager.LoadScene(scene);
    }

    private void OnTriggerEnter2D(Collider2D objCollider) {
        Debug.Log("é o pijas: " + objCollider.name);

        if (objCollider.name == "EntradaCasa"){
            //passa o parametro la pra tela de loading
            PlayerPrefs.SetString("Cena", "Home");
            //carrega tela de loading
            LoadScenes("TransitionScreen");
        }
        if (objCollider.name == "PortaHome"){
            PlayerPrefs.SetString("Cena", "MenuHome");
            LoadScenes("TransitionScreen");    
        }
        if (objCollider.name == "EstanteTrofeus"){
            LoadScenes("Estante");   
        }
        if (objCollider.name == "EntradaShop"){
            PlayerPrefs.SetString("Cena", "Shop");
            LoadScenes("TransitionScreen");    
        }
        if (objCollider.name == "PortaShop"){
            PlayerPrefs.SetString("Cena", "MenuShop");
            LoadScenes("TransitionScreen");
        }
        if (objCollider.name == "EntradaSchool"){
            PlayerPrefs.SetString("Cena", "School");
            LoadScenes("TransitionScreen");    
        }
        if (objCollider.name == "PortaSchool"){
            PlayerPrefs.SetString("Cena", "MenuSchool");
            LoadScenes("TransitionScreen");
        }
        if (objCollider.name == "EntradaSala"){
            LoadScenes("RoomSchool");
        }
        if (objCollider.name == "PortaSala"){
            LoadScenes("School");
        }
        if (objCollider.name == "EntradaMuseu"){
            PlayerPrefs.SetString("Cena", "Museu");
            LoadScenes("TransitionScreen");    
        }
        if (objCollider.name == "PortaMuseu"){
            PlayerPrefs.SetString("Cena", "MenuMuseu");
            LoadScenes("TransitionScreen");
        }
        if (objCollider.name == "SobeMuseu"){
            LoadScenes("Museu2");    
        }
        if (objCollider.name == "DesceMuseu"){
            LoadScenes("Museu");
        }
        if (objCollider.name == "BalcaoMuseu"){
            LoadScenes("OptionsMuseu");
        }
        if (objCollider.name == "EntradaBanco"){
            PlayerPrefs.SetString("Cena", "Bank");
            LoadScenes("TransitionScreen");    
        }
        if (objCollider.name == "CashMachine"){
            LoadScenes("CaixaEletronico");
        }
        if (objCollider.name == "PortaBank"){
            PlayerPrefs.SetString("Cena", "MenuBank");
            LoadScenes("TransitionScreen");
        }
    }
}

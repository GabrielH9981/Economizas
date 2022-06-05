using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneratePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject activePlayer;

    public GameObject basePlayer;
    public GameObject alienPlayer;
    public GameObject cartolaPlayer;
    public GameObject faixaPlayer;
    public GameObject ghostPlayer;
    public GameObject maskPlayer;
    public GameObject pirataPlayer;
    public GameObject vikingPlayer;
    public GameObject witcherPlayer;

    public Scene scene;
    public string selectedPlayer;
    
    void Start()
    {
        selectedPlayer = PlayerPrefs.GetString("selectedPlayer", selectedPlayer);
        if (selectedPlayer == "alienPlayer"){
            activePlayer = alienPlayer;
        }
        if (selectedPlayer == "cartolaPlayer"){
            activePlayer = cartolaPlayer;
        }
        if (selectedPlayer == "faixaPlayer"){
            activePlayer = faixaPlayer;
        }
        if (selectedPlayer == "ghostPlayer"){
            activePlayer = ghostPlayer;
        }
        if (selectedPlayer == "maskPlayer"){
            activePlayer = maskPlayer;
        }
        if (selectedPlayer == "pirataPlayer"){
            activePlayer = pirataPlayer;
        }
        if (selectedPlayer == "vikingPlayer"){
            activePlayer = vikingPlayer;
        }
        if (selectedPlayer == "witcherPlayer"){
            activePlayer = witcherPlayer;
        }
        if (selectedPlayer == "basePlayer"){
            activePlayer = basePlayer;
        }

        scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");

        if (scene.name == "MenuHome"){
            Instantiate(activePlayer, new Vector3(-10.51305f, 9.488046f, 0), Quaternion.identity);
        }
        if (scene.name == "MenuShop"){
            Instantiate(activePlayer, new Vector3(-0.5136449f, 9.703087f, 0), Quaternion.identity);
        }
        if (scene.name == "MenuSchool"){
            Instantiate(activePlayer, new Vector3(11.51f, 8.97f, 0), Quaternion.identity);
        }
        if (scene.name == "MenuMuseu"){
            Instantiate(activePlayer, new Vector3(27.56f, 6.33f, 0), Quaternion.identity);
        }
        if (scene.name == "MenuBank"){
            Instantiate(activePlayer, new Vector3(7.51f, -4.27f, 0), Quaternion.identity);
        }
        if (scene.name == "Home"){
            Instantiate(activePlayer, new Vector3(3.035783f, -2.986994f, 0), Quaternion.identity);
        }
        if (scene.name == "Museu"){
            Instantiate(activePlayer, new Vector3(1.914281f, -2.16456f, 0), Quaternion.identity);
        }
        if (scene.name == "Museu2"){
            Instantiate(activePlayer, new Vector3(5.353547f, 8.078514f, 0), Quaternion.identity);
        }
        if (scene.name == "RoomSchool"){
            Instantiate(activePlayer, new Vector3(2.998396f, -3.211264f, 0), Quaternion.identity);
        }
        if (scene.name == "School"){
            Instantiate(activePlayer, new Vector3(-0.02965784f, 2.807459f, 0), Quaternion.identity);
        }
        if (scene.name == "Shop"){
            Instantiate(activePlayer, new Vector3(-1.039009f, -3.248648f, 0), Quaternion.identity);
        }
        if (scene.name == "Bank"){
            Instantiate(activePlayer, new Vector3(0.007725477f, -3.173881f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

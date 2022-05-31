using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerGame : MonoBehaviour
{
    public int money;
    public Text textSaldo;

    public Text cronLimonada;
    public Text cronArtesanato;
    public Text cronAjudar;
    public Text cronBrinquedos;

    public float timerLimonada = 5;
    public float timerArtesanato = 10;
    public float timerAjudar = 20;
    public float timerBrinquedos = 60;

    bool isRunningLimonada = false;
    bool isRunningArtesanato = false;
    bool isRunningAjudar = false;
    bool isRunningBrinquedos = false;
    // Start is called before the first frame update

    public void UpdateSaldo(){
        textSaldo.text = money.ToString();
    }

    public void StartLimonada(){
        isRunningLimonada = true;
    }

    public void StartArtesanato(){
        isRunningArtesanato = true;
    }

    public void StartAjudar(){
        isRunningAjudar = true;
    }

    public void StartBrinquedos(){
        isRunningBrinquedos = true;
    }

    void Start()
    {
        money = PlayerPrefs.GetInt("moneyValue", (int)money);
        UpdateSaldo();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunningLimonada)
        {
            timerLimonada -= Time.deltaTime;
            cronLimonada.text = "Tempo: " + Mathf.RoundToInt(timerLimonada).ToString() + " s";

            if (timerLimonada < 0){
                isRunningLimonada = false;
                timerLimonada=5;
                money += 2;
                PlayerPrefs.SetInt("moneyValue", (int)money);
                UpdateSaldo();
            }
        }
 // ------------------------------------------------------------------------------------------------------------------- //
        if (isRunningArtesanato)
        {
            timerArtesanato -= Time.deltaTime;
            cronArtesanato.text = "Tempo: " + Mathf.RoundToInt(timerArtesanato).ToString() + " s";

            if (timerArtesanato < 0){
                isRunningArtesanato = false;
                timerArtesanato=10;
                money += 5;
                PlayerPrefs.SetInt("moneyValue", (int)money);
                UpdateSaldo();
            }
        }

        // ------------------------------------------------------------------------------------------------------------------- //
        if (isRunningAjudar)
        {
            timerAjudar -= Time.deltaTime;
            cronAjudar.text = "Tempo: " + Mathf.RoundToInt(timerAjudar).ToString() + " s";

            if (timerAjudar < 0){
                isRunningAjudar = false;
                timerAjudar=20;
                money += 10;
                PlayerPrefs.SetInt("moneyValue", (int)money);
                UpdateSaldo();
            }
        }

        // ------------------------------------------------------------------------------------------------------------------- //
        if (isRunningBrinquedos)
        {
            timerBrinquedos -= Time.deltaTime;
            cronBrinquedos.text = "Tempo: " + Mathf.RoundToInt(timerBrinquedos).ToString() + " s";

            if (timerBrinquedos < 0){
                isRunningBrinquedos = false;
                timerBrinquedos=60;
                money += 25;
                PlayerPrefs.SetInt("moneyValue", (int)money);
                UpdateSaldo();
            }
        }
    }
}

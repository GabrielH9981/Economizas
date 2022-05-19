using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InvestSystem : MonoBehaviour
{
    public MoneySistem _object;
    int segundos;
    public Text _text;
    int money;
    int moneyInvested;
    public int acumulatedProfit = 0;

    void Start()
    {
        money = _object.money;
        moneyInvested = _object.moneyInvested;
    }

    // Update is called once per frame
    void Update()
    {
        //_text.text = System.DateTime.Now.ToString("hh:mm:ss");
        _text.text = System.DateTime.Now.ToString("ss");

        if (System.DateTime.Now.ToString("ss") == "00" || System.DateTime.Now.ToString("ss") == "05" || System.DateTime.Now.ToString("ss") == "10" || System.DateTime.Now.ToString("ss") == "15" || System.DateTime.Now.ToString("ss") == "20" || System.DateTime.Now.ToString("ss") == "25" || System.DateTime.Now.ToString("ss") == "30" || System.DateTime.Now.ToString("ss") == "35" || System.DateTime.Now.ToString("ss") == "40" || System.DateTime.Now.ToString("ss") == "45" || System.DateTime.Now.ToString("ss") == "50" || System.DateTime.Now.ToString("ss") == "55"){
            //int moneyX = Int32.Parse(_object.money);
            int profit = Random.Range(-1,2);

            acumulatedProfit += profit;

            moneyInvested = (_object.moneyInvested + profit);
            //Debug.Log("random " + typeof(profit));
            Debug.Log("dinheiros " + moneyInvested);
            PlayerPrefs.SetInt("investValue", (int)moneyInvested);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //System.Threading.Thread.Sleep(1000);
        }
    }
}

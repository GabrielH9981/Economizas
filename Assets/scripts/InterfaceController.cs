using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    
    public Text textSaldo;
    public Text textName;
    private int money;
    private string name;

    void Start()
    {
        money = PlayerPrefs.GetInt("moneyValue", (int)money);
        name = PlayerPrefs.GetString("playerName", name);
    }

    // Update is called once per frame
    void Update()
    {
        textSaldo.text = money.ToString();
        textName.text = name.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfitController : MonoBehaviour
{
    public InvestSystem _object;
    private Text _text;
    
    void Start()
    {
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = _object.acumulatedProfit.ToString();
    }
}

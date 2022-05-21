using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmprestimoController : MonoBehaviour
{
    public MoneySistem _object;
    public Text textDivida;
    public Text textDisponivel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textDivida.text = _object.divida.ToString();
        textDisponivel.text = _object.emprestimoDisponivel.ToString();
    }
}

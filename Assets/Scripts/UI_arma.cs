using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_arma : MonoBehaviour
{

    public TMP_Text meuTexto;
    private Atirararma minhaArma;
    void Start()
    {
        minhaArma = GameObject.FindGameObjectWithTag("Arma").GetComponent<Atirararma>();
    }

    void Update()
    {
        meuTexto.text = "Arma: " + minhaArma.municao.ToString() + " / " + minhaArma.limiteMunicao.ToString();
    }
}

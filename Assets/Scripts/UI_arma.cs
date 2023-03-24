using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_arma : MonoBehaviour
{

    public TMP_Text meuTexto;
    public Atirararma minhaArma;
    void Start()
    {
    }

    void Update()
    {
        meuTexto.text = "Arma: " + minhaArma.municao.ToString() + " / " + minhaArma.limiteMunicao.ToString();
    }
}

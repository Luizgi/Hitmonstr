using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_arma : MonoBehaviour
{

    public TMP_Text meuTexto;
    private Atirararma minhaArma;
    // Start is called before the first frame update
    void Start()
    {
        minhaArma = GameObject.FindGameObjectWithTag("Arma").GetComponent<Atirararma>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

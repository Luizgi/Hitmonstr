using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirararma : MonoBehaviour
{
    public GameObject PontoDeSaida;
    public GameObject Bala;
    
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(Bala, PontoDeSaida.transform.position, Quaternion.identity);
        }
    }
}

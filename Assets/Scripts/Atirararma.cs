using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirararma : MonoBehaviour
{
    public GameObject PontoDeSaida;
    public GameObject Bala;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Disparo = Instantiate(Bala, PontoDeSaida.transform.position, Quaternion.identity);
            Disparo.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        }
    }
}

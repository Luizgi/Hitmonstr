using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirararma : MonoBehaviour
{
    public GameObject PontoDeSaida;

    public GameObject Bala;
    public int limiteMunicao = 30;
    public int municao = 30;

    private void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Confined;
        UnityEngine.Cursor.visible = false;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (municao > 0)
            {
                municao--;
                
                GameObject Disparo = Instantiate(Bala, PontoDeSaida.transform.position, Quaternion.identity);
                Disparo.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                Destroy(Disparo, 2f);
            }
        }
    }

    public void Carregar()
    {
        municao = municao + 10;
        if(municao > 30)
        {
            municao = 30;
        }
    }
}

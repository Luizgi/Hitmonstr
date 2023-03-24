using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Corpo : MonoBehaviour
{
    private Rigidbody Rb;
    private Animator Anim;
    public float sensibilidade;
    private float velocidadeP;
    public Image sangue;

    public int hp = 100;

    public GameObject TelaMorte;


    void Start()
    {

        
        Rb = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        //Correr
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidadeP = 12;
        }
        else
        {
            velocidadeP = 5;
        }

        //Movimento Andar
        float velZ = Input.GetAxis("Vertical") * velocidadeP;
        float velX = Input.GetAxis("Horizontal") * velocidadeP;
        //PosCorrigida
        Vector3 velCorrigida = velX * transform.right + velZ * transform.forward;

        Rb.velocity = new Vector3(velCorrigida.x, Rb.velocity.y, velCorrigida.z);

        if(velX != 0 || velZ !=0)
        {
            Anim.SetBool("Andar", true);
        }
        else if(velX == 0 && velZ == 0)
        {
            Anim.SetBool("Andar", false);
        }

        //Movimento Girar
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);


    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ataque_Inimigo")
        {
            hp = hp - 10;
            float alphaSangue = (float)hp / 100;
            alphaSangue = 1 - alphaSangue;
            
            sangue.color = new Vector4(1, 1, 1, alphaSangue);
            if(hp <= 0)
            {
                TelaMorte.SetActive(true);
            }
        }
    }

}

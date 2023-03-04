using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bala")
        {
            Destroy(collision.gameObject);
            Anim.SetTrigger("Morte");
            Destroy(this.gameObject, 2f);
            
        }
    }


}

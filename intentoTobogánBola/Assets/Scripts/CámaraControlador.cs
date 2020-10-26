using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CámaraControlador : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 diferencia;
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        diferencia = transform.position - jugador.transform.position;
        anim = GetComponent<Animator>();   
    }

    void Update()
    {
        
        if(Input.GetKeyDown("1"))
        {
           anim.Play("Cam03");
        }

        if(Input.GetKeyDown("2"))
        {
           anim.Play("Cam01 0");
        }

       
        if(Input.GetKeyDown("3"))
        {
           anim.Play("Cam02 0");
        }
    }

    void LateUpdate()
    {
        Vector3 nuevaPos = jugador.transform.position + diferencia;
        transform.position = nuevaPos;
    }
}

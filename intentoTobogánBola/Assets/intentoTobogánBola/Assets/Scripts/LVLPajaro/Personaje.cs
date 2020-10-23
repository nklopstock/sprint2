using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float velMovimiento  =5.0f;
    public float velRotacion = 200.0f;
    public Animator anim;
    public float x, y;

    // Update is called once per frame
    void Update()
    {
        x= Input.GetAxis("Horizontal");
        y= Input.GetAxis("Vertical");
        transform.Rotate(0,x*Time.deltaTime*velRotacion,0);
        transform.Translate(0,0,y*Time.deltaTime*velMovimiento);
        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);
    }
}

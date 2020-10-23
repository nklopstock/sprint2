using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public float velMovimiento  =5.0f;
    public float velRotacion = 200.0f;
    public Animator anim;
    public float DagnoPlayer=5;
    public float x, y;
    public Rigidbody rb;
    public float jumpHeight=8f;
    public bool isGrounded;
    private float inicioDisparo;
    public float tiempoDisparo;
    public float VelDisparo;
    public Transform lanzador;
    public GameObject flechaPrefab;
    public int Arco=0;
    public int Comida=0;
    public Text textoArco;
    public Text textoComida;
    public float angulo;
    void Start() {
        isGrounded=false;
        textoArco.text= "Armas: "+Arco.ToString();
        textoComida.text= "Comida: "+Comida.ToString();
    }
    void FixedUpdate() {
            transform.Rotate(0,x*Time.deltaTime*velRotacion,0);
            transform.Translate(0,0,y*Time.deltaTime*velMovimiento);
            angulo = transform.eulerAngles.y;

    }
    void Update()
    {    
        x= Input.GetAxis("Horizontal");
        y= Input.GetAxis("Vertical");

        if(Input.GetMouseButtonDown(0) && isGrounded)
        {
            anim.SetTrigger("Golpe");
            GameObject proyectilObjeto = Instantiate(flechaPrefab);
            proyectilObjeto.transform.position = lanzador.position + lanzador.forward;
            proyectilObjeto.transform.forward = lanzador.forward;
        }
        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);



        if (isGrounded){
                if(Input.GetKeyDown(KeyCode.Space)){
                    anim.SetBool("Jump",true);
                    rb.AddForce(new Vector3(0,jumpHeight,0),ForceMode.Impulse);
                }
            anim.SetBool("Grounding",true);
        }else{
            Falling();
        }
    }
    public void Falling(){
        anim.SetBool("Jump",false);
        anim.SetBool("Grounding",false);
    }
    void OnTriggerEnter(Collider otro){
        if(otro.gameObject.CompareTag("Arco")){
            otro.gameObject.SetActive(false);
            Arco++;
            DagnoPlayer=10;
            cambiarTexto();
        }
        if(otro.gameObject.CompareTag("Comida")){
            otro.gameObject.SetActive(false);
            Comida++;
            cambiarTexto();
        }
    }
    void cambiarTexto(){
            if(Comida>0){
                textoComida.text= "Comida: "+(Comida).ToString();
            }
            if(Arco>0){
                textoArco.text= "Armas: "+(Arco).ToString();
            }

    }
}

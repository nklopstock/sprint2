using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public float velMovimiento  = 5.0f;
    public float velRotacion = 200.0f;
    private Animator anim;
    public float DagnoPlayer=10;
    public float x, y;
    public Rigidbody rb;
    public float jumpHeight=5f;
    public bool isGrounded;
    public Transform lanzador;
    public GameObject ProyectilPrefab;
    public int Arma=0;
    public int Comida=0;
    public Text textoArma;
    public Text textoComida;
    public Text TxtEstado;
    public bool attacking = false;
    public AveScript ave;
    private float dagnoAve;
    public LogicaVida logicaVidaPlayer;
    public Camera Cinematica;
    public bool Estado;
    public PauseMenu menu;
    void Start() {
        Estado=false;
        Cinematica.enabled = false;
        menu = GameObject.Find("Canvas").GetComponent<PauseMenu>();
        ave = GameObject.Find("Ave").GetComponent<AveScript>();
        anim = GetComponent<Animator>();
        isGrounded=false;
        textoArma.text= "Armas: "+Arma.ToString();
        textoComida.text= "Comida: "+Comida.ToString();
    }
    void FixedUpdate() {
            if (!attacking){
                transform.Rotate(0,x*Time.deltaTime*velRotacion,0);
                transform.Translate(0,0,y*Time.deltaTime*velMovimiento);
            }

    }
    void Update()
    {
        dagnoAve = ave.getDagno();
        x= Input.GetAxis("Horizontal");
        y= Input.GetAxis("Vertical");

        if(Input.GetMouseButtonDown(0) && isGrounded && !attacking)
        {
            anim.SetTrigger("Golpe");
            attacking = true;
        }
        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);



        if (isGrounded && !attacking){
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
        if(otro.gameObject.CompareTag("Arma")){
            otro.gameObject.SetActive(false);
            Arma++;
            DagnoPlayer=25;
            cambiarTexto();
        }
        if(otro.gameObject.CompareTag("Comida")){
            otro.gameObject.SetActive(false);
            Comida++;
            cambiarTexto();
        }
    }
    public float getDagno (){
        return DagnoPlayer;
    }
    public void setComida (int num){
        Comida=num;
    }
    void cambiarTexto(){
            if(Comida>=0){
                textoComida.text= "Comida: "+(Comida).ToString();
            }
            if(Arma>=0){
                textoArma.text= "Armas: "+(Arma).ToString();
            }

    }
    public void DejeAtaque(){
        attacking=false;
    }
    public void Atacando(){
        GameObject proyectilObjeto = Instantiate(ProyectilPrefab, lanzador.position, Quaternion.identity) as GameObject;
        proyectilObjeto.transform.position = lanzador.position + lanzador.transform.forward;
        proyectilObjeto.transform.forward = lanzador.transform.forward;
    }
    public void Colision(){
        logicaVidaPlayer.vidaActual-=dagnoAve;
        bool muerte = logicaVidaPlayer.MuertePersonaje(Comida);
        cambiarTexto();
        if(muerte){
            Muerte();
        }
    }
    public void Muerte(){
        TxtEstado.text= "Haz Muerto";
        Estado = true;
        menu.PanelEstado(Estado);
        Cinematica.enabled = true;
        gameObject.SetActive(false);
    }
    public void Victoria(){
        TxtEstado.text= "Victoria";
        Estado = true;
        menu.PanelEstado(Estado);
    }
}

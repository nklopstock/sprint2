using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaVida : MonoBehaviour
{
    public int vidaMax;
    public float vidaActual;
    public Image imagenBarraVida;
    private Personaje player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Personaje").GetComponent<Personaje>();
        vidaActual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();
    }
    public void RevisarVida(){
        imagenBarraVida.fillAmount = vidaActual/vidaMax;
    }
    public bool MuertePersonaje(int vidas){
        bool muerte =false;
        if (vidaActual <=0){
            if(vidas>0){
                imagenBarraVida.fillAmount = vidas*0.20f;
                vidaActual = vidas*((vidaMax*20)/100);
                muerte = false;
                player.setComida(0);
            }else{
                muerte=true;
            }
        }
        return muerte;
    }
    public bool MuerteAve(){
        bool muerte=false;
        if (vidaActual <=0){
            muerte=true;
        }
        return muerte;
    }
}

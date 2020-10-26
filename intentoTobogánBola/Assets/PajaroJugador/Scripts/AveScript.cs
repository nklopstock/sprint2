using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AveScript : MonoBehaviour
{
    public LogicaVida logicaVidaAve;
    private Personaje player;
    private float dagnoPlayer;
    public float dagnoAve=10;
    public Transform lanzador1;
    public Transform lanzador2;
    public Transform lanzador3;
    public Transform lanzador4;
    public Transform lanzador5;
    public GameObject ProyectilPrefabAve;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Personaje").GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        dagnoPlayer = player.getDagno();
    }
    public void Colision(){
        logicaVidaAve.vidaActual-=dagnoPlayer;
        bool muerte = logicaVidaAve.MuerteAve();
        if (muerte){
            player.Victoria();
        }else{
            AtacandoAve(lanzador1);
            AtacandoAve(lanzador2);
            AtacandoAve(lanzador3);
            AtacandoAve(lanzador4);
            AtacandoAve(lanzador5);
        }
    }
    public void AtacandoAve(Transform firePoint){
        GameObject proyectilObjeto = Instantiate(ProyectilPrefabAve, firePoint.position, Quaternion.identity) as GameObject;
        proyectilObjeto.transform.position = firePoint.position + firePoint.transform.forward;
        proyectilObjeto.transform.forward = firePoint.transform.forward;
    }
    public float getDagno (){
        return dagnoAve;
    }
}

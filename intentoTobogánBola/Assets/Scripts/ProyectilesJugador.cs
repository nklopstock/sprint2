using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilesJugador : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public GameObject jugador;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject proyectilObjeto = Instantiate(proyectilPrefab);
            proyectilObjeto.transform.position = jugador.transform.position + jugador.transform.forward;
            proyectilObjeto.transform.forward = jugador.transform.forward;
        }
    }
}


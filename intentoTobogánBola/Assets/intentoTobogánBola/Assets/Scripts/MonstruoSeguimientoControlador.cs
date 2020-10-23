using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstruoSeguimientoControlador : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 diferencia;

    // Start is called before the first frame update
    void Start()
    {
        diferencia = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 nuevaPos = jugador.transform.position + diferencia;
        transform.position = nuevaPos;
    }
}

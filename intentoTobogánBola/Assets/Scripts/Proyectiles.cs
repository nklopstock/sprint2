using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectiles : MonoBehaviour
{
    public float velocidad;

    // Update is called once per frame
    void Update()
    {        
        //Hacer que el proyectíl se mueva.
        transform.position += transform.forward * velocidad * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pared"))
        {
            Destroy(gameObject);
        }
    }
}

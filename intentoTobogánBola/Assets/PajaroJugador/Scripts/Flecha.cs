using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Flecha : MonoBehaviour
{
    public float velocidad=0.5f;

    // Update is called once per frame
    void Update()
    {        
        transform.position += transform.forward * velocidad * Time.deltaTime;
    }
}

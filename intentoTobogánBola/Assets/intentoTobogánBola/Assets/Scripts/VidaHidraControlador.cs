using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaHidraControlador : MonoBehaviour
{
    private int conteoVida;
    private Rigidbody rb;
    public Text textoVidas;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        conteoVida = 20;
        cambiarTexto();
    }

    void OnTriggerEnter(Collider otro)
    {
        if(otro.gameObject.name == "Hidra")
        {
            Debug.Log("Collision Detected");
            Destroy(gameObject);
            conteoVida -= 1;
            cambiarTexto();
        }
        
        if(conteoVida <= 0)
        {
            otro.gameObject.SetActive(false);
        }
    }

    void cambiarTexto()
    {
        textoVidas.text = "Vidas Hidra: " + conteoVida.ToString();
    }
}

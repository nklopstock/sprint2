using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaHidraControlador : MonoBehaviour
{
    private int conteoVida;

    // Start is called before the first frame update
    void Start()
    {
        conteoVida = 20;
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Hidra")
        {
            Debug.Log("Collision Detected");
            Destroy(gameObject);
            conteoVida -= 1;
            
            if(conteoVida <= 0)
            {
                Destroy(col.gameObject);
            }
        }
    }
}

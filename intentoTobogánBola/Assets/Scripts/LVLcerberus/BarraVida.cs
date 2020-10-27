using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class BarraVida : MonoBehaviour
{
    public int vidaMAX;
    public float vidaACTUAL;
    public Image imagenBarraVida;

    
    // Start is called before the first frame update
    void Start()
    {
        vidaACTUAL = vidaMAX;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();

        if ( vidaACTUAL <=0)
        {
            gameObject.SetActive(false);
        }
    }

    public void RevisarVida()
    {
        imagenBarraVida.fillAmount = vidaACTUAL / vidaMAX;
    }
}

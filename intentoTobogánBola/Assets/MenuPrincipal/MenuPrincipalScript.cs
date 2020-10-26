using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipalScript : MonoBehaviour
{
    public static bool gamePanel;
    public GameObject gameP;
    public static bool ExitPanel;
    public GameObject ExitP;
    public
    // Start is called before the first frame update
    void Start()
    {
        gameP.SetActive(false);
        ExitP.SetActive(false);
    }

    // Update is called once per frame
    public void PanelSeleccionar(){
        if (gamePanel){
            btnConfirma();
        }else{
            btnBack();
        }
    }
    public void btnConfirma(){
        gameP.SetActive(false);
        Time.timeScale=1;
        gamePanel=false;
    }
    public void btnBack(){
        gameP.SetActive(true);
        Time.timeScale=0;
        gamePanel=true;
    }
    public void AbrirNivel(string cadena){
        SceneManager.LoadScene(cadena);
    }
    public void PanelSalir(){
        ExitP.SetActive(true);
    }
    public void NoSalir(){
        ExitP.SetActive(false);
    }
    public void Salir(){
        Debug.Log("Se ha salido del juego");
        Application.Quit();
    }
}

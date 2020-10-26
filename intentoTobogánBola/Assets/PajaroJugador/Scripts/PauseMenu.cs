using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePanel;
    public GameObject menuP;
    public GameObject EstadoP;
    // Start is called before the first frame update
    void Start()
    {
        menuP.SetActive(false);
        EstadoP.SetActive(false);
    }

    // Update is called once per frame
    public void Pausante(){
        if (gamePanel){
            btnResume();
        }else{
            btnPause();
        }
    }
    public void btnResume(){
        menuP.SetActive(false);
        Time.timeScale=1;
        gamePanel=false;
    }
    public void btnPause(){
        menuP.SetActive(true);
        Time.timeScale=0;
        gamePanel=true;
    }
    public void MenuPrincipal(string cadena){
        SceneManager.LoadScene(cadena);
    }
    public void PanelEstado(bool verifica){
        EstadoP.SetActive(verifica);
    }
}

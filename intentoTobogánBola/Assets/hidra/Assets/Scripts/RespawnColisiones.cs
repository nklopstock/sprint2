using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnColisiones : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Jugador"))
        {
            Restart();
        }
        if(other.CompareTag("Proyectil"))
        {
            Destroy(other.gameObject);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

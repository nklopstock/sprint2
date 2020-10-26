using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilAve : MonoBehaviour
{
    public Personaje player;
    public float velocidad=30f;
    private bool collided=false;
    void Start()
    {
        player = GameObject.Find("Personaje").GetComponent<Personaje>();
    }
    void Update()
    {
        transform.position += transform.forward * velocidad * Time.deltaTime;
        if(transform.position.x > 100 || transform.position.x < -100|| transform.position.z > 100|| transform.position.z < -100){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision co) {
        if(co.gameObject.tag != "ProyectilPlayerPajaro" && co.gameObject.tag != "Ave" && !collided && co.gameObject.tag != "Ave"){
            collided=true;
            Destroy(gameObject);
        }
        if(co.gameObject.tag == "PlayerAver"){
            player.Colision();
            Destroy(gameObject);
        }
    }
    
}

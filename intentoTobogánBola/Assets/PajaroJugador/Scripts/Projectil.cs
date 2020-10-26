using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectil : MonoBehaviour
{
    public AveScript ave;
    public float velocidad=30f;
    private bool collided=false;
    void Start()
    {
        ave = GameObject.Find("Ave").GetComponent<AveScript>();
    }
    void Update()
    {
        transform.position += transform.forward * velocidad * Time.deltaTime;
        if(transform.position.x > 100 || transform.position.x < -100|| transform.position.z > 100|| transform.position.z < -100){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision co) {
        if(co.gameObject.tag != "ProyectilPlayerPajaro" && co.gameObject.tag != "PlayerAve" && !collided && co.gameObject.tag != "Ave"){
            collided=true;
            Destroy(gameObject);
        }
        if(co.gameObject.tag == "Ave"){
            ave.Colision();
            Destroy(gameObject);
        }
    }
    
}

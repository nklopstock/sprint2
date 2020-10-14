using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    /*public GameObject player;
    private Vector3 diferencia;*/
    // Start is called before the first frame update
    void Start()
    {
        //diferencia=transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetAxis ("Mouse ScrollWheel")>0){
            GetComponent<Camera>().fieldOfView--;
        }if(Input.GetAxis ("Mouse ScrollWheel")<0){
            GetComponent<Camera>().fieldOfView++;
        }
        /*Vector3 NuevaPos = player.transform.position+diferencia;
        transform.position = NuevaPos;*/
    }
}


/*yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;*/
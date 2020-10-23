using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider otro){
        if(otro.gameObject.CompareTag("Flecha")){
            Dagno();
        }
    }
    private void Dagno(){

    }
}

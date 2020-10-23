using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorControlador : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movimiento = new Vector3(horizontal, 0f, 0f).normalized;

        rb.AddForce(movimiento * velocidad);

    }
}

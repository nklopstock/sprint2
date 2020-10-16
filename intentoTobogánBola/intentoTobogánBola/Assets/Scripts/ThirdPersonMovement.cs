using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rb;

    private Transform player;
    private Transform respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal, 0f, 0f) * velocidad * Time.deltaTime;
        transform.Translate(movimiento, Space.Self);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;

    public Animator animator;

    public float x,y;

    public Rigidbody rb;
    
    public float jumper = 1;

    public Transform groundCheck;
    public float  groundDistance = 0.1f;

    public LayerMask grounddMask;

    bool isGround;

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed); 
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);  

        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, grounddMask);

        if (Input.GetKey("space")&& isGround)
        {
            Invoke("Jump", 0.5f);
            animator.Play("Jumping Up");

            
        }
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * jumper, ForceMode.Impulse);
    }


}



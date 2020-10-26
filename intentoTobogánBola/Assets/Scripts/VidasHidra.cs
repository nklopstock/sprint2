using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasHidra : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;

    public BarraVidas healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Proyectil"))
        {
            TakeDamage(1);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
        

}

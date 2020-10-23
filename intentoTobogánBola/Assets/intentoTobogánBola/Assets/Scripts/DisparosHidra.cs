using UnityEngine;
using UnityEngine.AI;

public class DisparosHidra : MonoBehaviour
{
    public Transform target;
    public float range = 12f;

    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()
    {

        if(fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Cambiox2"))
            {
                fireRate = fireRate + 3;
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
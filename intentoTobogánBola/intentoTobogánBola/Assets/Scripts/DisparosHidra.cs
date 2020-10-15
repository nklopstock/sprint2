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

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    
    void Update()
    {
        if (target = null)
        {
            return;
        }

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
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}

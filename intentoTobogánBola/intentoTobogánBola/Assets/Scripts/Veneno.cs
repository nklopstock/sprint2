using UnityEngine;

public class Veneno : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public float lifeDuration = 2f;
    private float lifeTimer;

    void Start()
    {
        lifeTimer = lifeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimer -= Time.deltaTime;

        if(lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}

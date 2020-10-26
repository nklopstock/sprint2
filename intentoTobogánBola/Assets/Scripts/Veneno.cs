using UnityEngine;

public class Veneno : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    private float lifeTimer;
    public float lifeDuration = 2f;

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
            Destroy(this.gameObject);
        }
    }
}

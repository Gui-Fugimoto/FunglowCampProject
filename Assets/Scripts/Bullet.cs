
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public float bulletDamage = 10f;
    public Rigidbody rb;

    private void FixedUpdate()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Inimigo"))
        {
            Destroy(gameObject);
        }
    }
}

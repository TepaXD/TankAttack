using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject explosion = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(explosion, 1f);
        Destroy(gameObject);
    }

}

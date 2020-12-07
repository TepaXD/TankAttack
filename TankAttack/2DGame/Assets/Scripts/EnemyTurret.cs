using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Transform player;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (this.CompareTag("Enemy2"))
        {
            rb.rotation = angle;

        } else
        {
            rb.rotation = angle - 90;

        }
    }
}

using UnityEngine;

public class PlayerBottom : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int maxHealth = 3;
    public int currentHealth;
    public int explosionLimiter = 2;
    public int explosions = 0;

    public Healthbar healthbar;
    public Rigidbody2D rb;
    public Animator animator;
    public GameObject hitEffect;

    Vector2 movement;

    private void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(currentHealth <= 0)
        {
            if(explosions <= explosionLimiter) {
                GameObject explosion = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(explosion, 1f);
                explosions++;
            }
            else
            {
                PlayerDeath();

            }
        }
    }

    void FixedUpdate()
    {
        if (!PlayerManager.isDead)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
        }
        
    }

    void PlayerDeath()
    {
        FindObjectOfType<GameManager>().GameOver();
    }
}

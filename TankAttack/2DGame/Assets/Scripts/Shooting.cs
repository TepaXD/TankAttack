using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float interval = 2f;
    public float nextShot = 0.0f;
    public float bulletForce = 5f;

    public Transform firePoint;
    public GameObject bulletPrefab;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(Time.time >= nextShot)
            {
                nextShot = Time.time + interval;
                if (PlayerManager.isDead == false)
                {
                    Shoot();
                }
                
                
            }
            
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTop : MonoBehaviour
{
    public float moveSpeed = 5f;


    public Rigidbody2D rb;
    public Camera cam;

    Vector2 mousePos;
    Vector2 movement;



    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        if(!PlayerManager.isDead)
        {
            //Move the tank top at the same speed as the bottom to have them align
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

            //Rotation of ship to mouse position
            Vector2 lookDir = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
        }
    }
}

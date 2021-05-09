using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    
    Vector2 PlayerPos;
    Vector2 moveDirc;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    //seting the speed and rididbody
        moveSpeed = 5;
  
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //method for checking what way to move player
        Inputs();
    }

   void FixedUpdate()
    {
        //moves the play on an fixed update time
        Move();
    }

    void Inputs()
    {
        //creates a direction vector based of the inputs
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirc = new Vector2(moveX, moveY);
    }
     void Move()
    {
       // moveSpeed the player
        rb.velocity = new Vector2(moveDirc.x * moveSpeed, moveDirc.y * moveSpeed);
    }
}

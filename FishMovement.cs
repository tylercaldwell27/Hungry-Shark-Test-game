using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed;
    Vector2 moveTo;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = Random.Range(1, 3);
    }



    void FixedUpdate()
    {
        //moves the play on an fixed update time
        Move();
    }

   //the speed of the fish moving down the screen
    void Move()
    {
        // moveSpeed the player
        speed = 5;
        rb.velocity = new Vector2(moveTo.x* speed, moveTo.y * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if the player runs into a good fish
        if (collision.gameObject.tag == "BottomBoarder")
        {
            Destroy(this.gameObject);
            
        }
    }
}

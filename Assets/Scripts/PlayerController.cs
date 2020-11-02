using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float moveInputDirection;
    private Rigidbody2D rb;
    public float moveSpeed;
    public float jumpForce;

    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        endScreen.SetActive(false); // hide endscreen on start
    }
    // Update is called once per frame
    void Update()
    {
        // left/right movement
        moveInputDirection = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            // jump
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    private void FixedUpdate()
    {
        // update pos
        rb.velocity = new Vector2(moveSpeed * moveInputDirection, rb.velocity.y);
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // detects a bullet has hit the player
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(collision.gameObject); // destroy bullet
            Destroy(this.gameObject);      // destroy player
            endScreen.SetActive(true);     // show end screen
        }
    }
}
   
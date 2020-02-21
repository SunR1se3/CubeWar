using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;
    readonly Vector2 force = new Vector2(0, 50);
    bool inAir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * h * speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.W) && !inAir)
        {
            inAir = true;
            rb.AddForce(force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            inAir = false;
    }
}

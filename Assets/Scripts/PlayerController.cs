using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] private float speed;
    [SerializeField] private float limit;
    
    private bool isJumping => rb.velocity.y > 0.01f;
    private float input;

    public void Jump(float force)
    {
        if (isJumping) return;

        var velocity = rb.velocity;
        velocity.y = force;
        rb.velocity = velocity;
    }

    void Update()
    {
        input = Input.GetAxis("Horizontal");
        if(input != 0)
        {
            spriteRenderer.flipX = input < 0;
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var position = transform.position;

        // **Önce input ile hareket et**
        position.x += input * speed * Time.deltaTime;

        // **Sonra Clamp ile sınırlandır**
        position.x = Mathf.Clamp(position.x, -limit, limit);

        transform.position = position;
    }
}

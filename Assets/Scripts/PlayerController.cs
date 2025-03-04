using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    public void Jump(float force)
    {
        var velocity = rb.velocity;
        velocity.y = force;
        rb.velocity = velocity;
    }
}
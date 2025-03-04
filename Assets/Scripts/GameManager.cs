using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}

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

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float force;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.CompareTag("Player"))
        {
            var player = other.transform.GetComponent<PlayerController>();
            player.Jump(force);
        }
    }
}

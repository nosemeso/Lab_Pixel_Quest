using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{

    private Rigidbody2D Player ;
    public int speed = 5;

    private void Start();
    
    
    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        Player.velocity = new Vector2(xInput * speed, kuri.velocity.y);
    }
}

    


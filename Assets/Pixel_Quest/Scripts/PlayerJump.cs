using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; 
    private Rigidbody2D rb;
    private bool isGrounded;


    public float CapsuleRadius;
    public float jumpforce = 10;
    public float fallforce = 2;
    public float CapsultHeight;
    public LayerMask groundLayer;
    public Transform feet;
    public bool _grounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _grounded = Physics2D.OverlapCapsule(feet.position, new Vector2(CapsultHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space)&& _grounded||waterchack)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        }}
        
       private bool waterchack = false;
    private string watertag = "Water";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(watertag))
        {
            waterchack = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(watertag))
        {
            waterchack = false;
        }
    }
}

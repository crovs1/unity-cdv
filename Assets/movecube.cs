using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecube : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D RigidBody2d;
    public KeyCode upKey;
    public KeyCode downKey;
    public Color colour;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        RigidBody2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = colour;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < 5)
        {
            RigidBody2d.velocity = Vector2.up * speed ;

        }

        else if (Input.GetKey(downKey) && transform.position.y > -5)
        {
            RigidBody2d.velocity = Vector2.down * speed;
        }
        else
        {
            RigidBody2d.velocity = Vector2.zero;
        }

    }
}

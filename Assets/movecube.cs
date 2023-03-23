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
        if (Input.GetKey(upKey))
        {
            RigidBody2d.velocity = Vector2.up * 3 ;

        }

        else if (Input.GetKey(downKey))
        {
            RigidBody2d.velocity = Vector2.down * 3;
        }
        else
        {
            RigidBody2d.velocity = Vector2.zero;
        }

    }
}

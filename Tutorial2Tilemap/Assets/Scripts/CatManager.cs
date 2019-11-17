using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    private Rigidbody2D rb2d;
    Animator anim;
    private bool facingRight = true;
    public float speed;
  






    // Start is called before the first frame update
    //I WILL GET THIS CAT RUNNING
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        // Walking to Idle
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("State", 0);
        }
        // for first animation

        // Jumping to Idle
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            anim.SetInteger("State", 0);
        }
        // for second animation
    }
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        //Vector2 movement = new Vector2(moveHorizontal, 0);

        // rb2d.AddForce(movement * speed);
        

    }
}

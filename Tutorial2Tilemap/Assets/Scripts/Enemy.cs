using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Animator anim;

    public float speed;

    public LayerMask isGround;

    public Transform wallHitBox;

    private bool wallHit;

    public float wallHitHeight;
    public float wallHitWidth;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(speed * Time.deltaTime, 0, 0);

        //wallHit is a bool similar to the ground one in the player code.
        //Physics2D.OverlapBox is similar to Physics2D.OverlapCircle but uses a box
        //The next is a Vector 2 with the box's Width and Height which are floats that I made public so I could edit them in the editor. 
        //The zero is the z value we don't need.
        //isGround is a LayerMask of everything that is ground.
        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);

        if (wallHit == true)
        {
            speed = speed * -1;
        }

    }

    private void OnColisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("I loved living");
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(wallHitBox.position, new Vector3(wallHitWidth, wallHitHeight, 1));
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    Animator anim;
    private Rigidbody2D rd2d;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        rd2d.AddForce(new Vector2(moveHorizontal * speed, moveVertical * speed));

        if (Input.GetKey("escape"))
            Application.Quit();

        {
            void OnTriggerEnter2D(Collider2D other)
            {
                
                if (other.gameObject.CompareTag("PickUp"))
                
                gameObject.SetActive(false);
            }
        }



        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {

            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetInteger("State", 2);

        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            anim.SetInteger("State", 0);
        }
        
    }

}

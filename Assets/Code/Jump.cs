using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Sprite[] animation;
    public float jumpHeight;
    private Rigidbody2D rigidbody;
    private int x;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)&& rigidbody.velocity.y<0.05f)
        {
            rigidbody.velocity += new Vector2(0, jumpHeight);
            GetComponent<AudioSource>().Play();
        }

        //if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > 0.6f) 
          //  rigidbody.velocity = new Vector2(0, -jumpHeight);
    }

   
}

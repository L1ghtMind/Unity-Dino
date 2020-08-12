using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObj : MonoBehaviour
{
    public Sprite[] animation;
    public Vector2 offset;
    public bool offsetY;
    public float moveSpeed = 0.01f;
    private int x;

    private void Awake()
    {
        if (offsetY)
            moveSpeed = 0.2f;
            StartCoroutine(Animation());
    }
    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - moveSpeed, transform.position.y);
        moveSpeed += moveSpeed / 8500;
       
        if (transform.position.x <= -10)
        {
            transform.position = new Vector2(transform.position.x + 20.84f + Random.Range(offset.x, offset.y), transform.position.y);

            if (offsetY)
                transform.position = new Vector2(transform.position.x, Random.Range(0.5f, 2f));
        }
    }
    IEnumerator Animation()
    {
        GetComponent<SpriteRenderer>().sprite = animation[x];
        yield return new WaitForSeconds(0.3f);
        if (x == 0)
            x = 1;
        else
            x = 0;
        StartCoroutine(Animation());
    }
}

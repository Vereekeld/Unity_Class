using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
     
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "LeftSide")
        {
            rb2d.AddForce(new Vector2(-60, 15), ForceMode2D.Impulse);
        }
        if (collision.collider.tag == "RightSide")
        {
            rb2d.AddForce(new Vector2(60, 15), ForceMode2D.Impulse);
        }
        if (collision.collider.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumps : MonoBehaviour
{
    public GameObject enjum;
    private Rigidbody2D rb2d;
    public AudioClip hit;
    public AudioSource musicSource;
    public float jumpForce;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
             rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if (collision.collider.tag == "Player")
        {
            musicSource.Play();
           gameObject.SetActive(false);
        }
    }
}

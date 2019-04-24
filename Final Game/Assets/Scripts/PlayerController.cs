using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb2d;
    private SpriteRenderer psr;
    private Vector3 target;
    private float thrust = 10.0f;
    public float speed;
    public float jumpForce;
    public int score, count, otherCount;
    public Text healthText;
    public Text scoreText;
    public Text winText;
    public int health;
    Animator anim;

    public AudioClip Jump;
    public AudioClip Coin;
    public AudioClip hit;
    public AudioClip Lvlm;
    public AudioClip victory;
    public AudioSource musicSource5;
    public AudioSource musicSource4;
    public AudioSource musicSource;
    public AudioSource musicSource2;
    public AudioSource musicSource3;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        psr = GetComponent<SpriteRenderer>();
        musicSource.clip = Lvlm;
        musicSource.Play();
        SetScoreText();
        SetHealthText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float movementX = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(movementX, 0);
        rb2d.AddForce(movement * speed);
        SetScoreText();
        SetHealthText();
        SetWinText();

        if (Input.GetKeyDown(KeyCode.D))
        {
            psr.flipX = false;
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            psr.flipX = true;
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetInteger("State", 0);
        }
        
        

    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetInteger("State", 2);
                rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                musicSource.clip = Jump;
                musicSource.Play();
            }
        }
        if (collision.collider.tag == "LeftSide")
        {
            rb2d.AddForce(new Vector2(-15,15), ForceMode2D.Impulse);
        }
        if (collision.collider.tag == "RightSide")
        {
            rb2d.AddForce(new Vector2(15, 15), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            score++;
            count++;
            musicSource.clip = Coin;
            musicSource.Play();
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            health--;
            score--;
            musicSource.clip = hit;
            musicSource.Play();
            other.gameObject.SetActive(false);
        }
        if (count == 4)
        {
            health = 3;
            player.transform.position = new Vector2(1029.8f, -3.9f);
        }

    }



    private void SetWinText()
    {
        if (count == 8)
        {
            musicSource.clip = Lvlm;
            musicSource.Stop();
            winText.text = "You Win!";
            Destroy(this);
            
            musicSource.clip = victory;
            musicSource.Play();
        }

    }

    private void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    private void SetOtherCountText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    private void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();

        if (health == 0)
        {
            Destroy(this);
            winText.text = "Game Over";
        }
    }
}

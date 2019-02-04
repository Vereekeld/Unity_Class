using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;//Public variable allows you to make changes in the unity editor.
    public Text countText;
    public Text scoreText;
    public Text winText;
    private Rigidbody rb;
    private int count, lives, score;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        score = 0;
        lives = 3;
        SetCountText();
        SetScoreText();
        winText.text = "";

    }

    private void FixedUpdate()//physics code goes here
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //determines the direction of the force

        rb.AddForce(movement*speed);
        if (Input.GetKey("escape"))
            Application.Quit();

    }

    void OnTriggerEnter(Collider other)//picking object
    {
        

        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            score++;
            SetCountText();
            SetScoreText();
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            lives--;
            SetCountText();
            SetScoreText();
        }
        

    }
   
        
    void SetCountText()
    {
        if (score == 12)
        {
            transform.position = new Vector3(110.0f, transform.position.y, 0.0f);
            score = 14;
        }
            

        countText.text = "Total Pickups: " + count.ToString();
        if(count==14)
            winText.text = "You Win!";
    }
    void SetScoreText()
    {
        scoreText.text = "Lives: " + lives.ToString();
        if (lives < 1)
        {
            Destroy(this);
            winText.text = "Game Over";
        }
    }
  
}

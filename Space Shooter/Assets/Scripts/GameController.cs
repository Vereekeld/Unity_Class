using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 SpawnValue;
    public int HazardCount;
    public float SpawnWait;
    public float StartWait;
    public float waveWait;

    public Text ScoreText;
    public Text restartText;
    public Text gameOverText;

    private int score;
    private bool gameOver;
    private bool restart;


    private void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine (spawnWaves());
    }
    private void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    IEnumerator spawnWaves()
    {
        yield return new WaitForSeconds(StartWait);

        while (true)
        {
             for (int i=0; i<HazardCount;i++)
             {
              Vector3 spawnPosition = new Vector3(Random.Range(-SpawnValue.x,SpawnValue.x),SpawnValue.y,SpawnValue.z);
              Quaternion spawnRotation = Quaternion.identity;
              Instantiate(hazard, spawnPosition, spawnRotation);
              yield return new WaitForSeconds(SpawnWait);
             }
            yield return new WaitForSeconds(waveWait);
            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
        
        
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore()
    {
        ScoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOver = true;
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    int noOfRows = 3;
    [SerializeField]
    int noOfCols = 8;

    [SerializeField]
    GameObject[] bricks;

    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    [SerializeField]
    GameObject gameOverPanel;

    int noOfBricks;

    int score;

    public bool isGameOver = false;

    public bool started { get; private set; }

    private static GameManager INSTANCE = null;

    public static GameManager GetInstance()
    {
        return INSTANCE;
    }

    void Awake()
    {
        INSTANCE = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        started = false;
        score = 0;
        scoreText.text = "Score: 0";
        noOfBricks = noOfRows * noOfCols;
        SpawnBricks();
        gameOverPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnBricks()
    {
        if (bricks != null && bricks.Length != 0)
        {
            const float stepY = 0.5f;
            const float stepX = 1f;
            int perLine = Mathf.FloorToInt(4.0f / stepX);

            for (int i = 0; i < noOfRows; ++i)
            {
                for (int x = 0; x < noOfCols; ++x)
                {
                    int k = UnityEngine.Random.Range(0, bricks.Length);
                    Vector3 position = new Vector3(-7.43f + stepX * x, 2.38f + i * stepY, 0);
                    var brick = Instantiate(bricks[k], position, Quaternion.identity);
                }
            }
        }
    }

    public void StartGame()
    {
        started = true;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
        noOfBricks--;
        if (noOfBricks <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

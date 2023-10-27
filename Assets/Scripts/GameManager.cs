using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] float resetGameDelay = 1;

    [SerializeField] TextMeshPro scoreText;
    [SerializeField] Canvas gameOverCanvas;

    int score = 0;

    void Awake() 
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start() 
    {
        scoreText.text = score.ToString();
        gameOverCanvas.gameObject.SetActive(false);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameOverCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("GAME OVER!");
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

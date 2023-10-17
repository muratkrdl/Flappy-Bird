using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshPro scoreText;

    int score = 0;

    void Update() 
    {
        scoreText.text = score.ToString();    
    }

    public void IncreaseScore()
    {
        score++;
    }
    
}

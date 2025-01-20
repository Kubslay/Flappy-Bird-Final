using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour 
{
    public int score;
 
    public Rigidbody2D rb2D;
    public TextElement ScoreText;
    // public Text ScoreText; 
    public GameManager managerGame;
    public TextMeshProUGUI TxtScore;
    void Start()
    {
        score= 0;                                                         // score U 0 dan ba�lat�r
        ScoreText.text = score.ToString();                                // stringe �evirme / metin format�na ge�er
        rb2D.linearVelocity = Vector2.up * birdy.velocity * 2;           // rb2D yi yukar� gitmesini sa�lar 
                                                                 
    }
    public void UpdateScore()
    {
        score++;                                                      // score u 1 artt�r�r
       TxtScore.text = score.ToString();                             // stringe �evirme 
    }

    public void RestartGame()                                      // oyun tekrar ba�lad���nda 
    {
     SceneManager.LoadScene(0);                                     //sahne "0"� y�kler    
    }
}
 
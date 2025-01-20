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
        score= 0;                                                         // score U 0 dan baþlatýr
        ScoreText.text = score.ToString();                                // stringe çevirme / metin formatýna geçer
        rb2D.linearVelocity = Vector2.up * birdy.velocity * 2;           // rb2D yi yukarý gitmesini saðlar 
                                                                 
    }
    public void UpdateScore()
    {
        score++;                                                      // score u 1 arttýrýr
       TxtScore.text = score.ToString();                             // stringe çevirme 
    }

    public void RestartGame()                                      // oyun tekrar baþladýðýnda 
    {
     SceneManager.LoadScene(0);                                     //sahne "0"ý yükler    
    }
}
 
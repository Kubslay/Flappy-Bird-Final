using UnityEngine;

public class birdy : MonoBehaviour
{
    // tanımlamalar
    public bool isDead;
    public static float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager managerGame;
    public GameObject DeathScreen;
    private void Start()                                                 // oyun başladığında çalışan fonksiyonlar
    {
        Time.timeScale = 1;                                             // zaman (oyun) akar.        
    }
    void Update()                                                        // her karede çalışan fonksiyonlar
    {
        if (Input.GetKeyDown(KeyCode.Space))                            // tiklamayi al (space)
          {
             rb2D.linearVelocity = Vector2.up * velocity*2;

          }

        if (Input.GetMouseButtonDown(0))     //tiklamayi al (mouse)
        {   
            
            rb2D.linearVelocity = Vector2.up * velocity*2;              //havada kusu sıcrat
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)                                     
    {
        if (collision.gameObject.name == "ScoreArea")                   // ScoreArea'ya girilirse (collision oluştuğunda) ...      
        {
            managerGame.UpdateScore();                                  // UpdateScore u çalıştırıyor ve score artıyor.
        }
            
    }
    private void OnCollisionEnter2D(Collision2D collision)              
    {
        if (collision.gameObject.tag == "DeathArea")                   // DeathArea olark taglenen yerlerde collission olursa.
        {
            isDead = true;                                             // isDead bool'unu true'ya çevir 
            Time.timeScale = 0;                                         // zamanı durdur
            DeathScreen.SetActive(true);                                // ölüm ekranını aktif et
                                                                         
        }
    }
}










    


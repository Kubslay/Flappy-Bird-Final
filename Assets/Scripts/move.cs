using UnityEngine;

public class Move : MonoBehaviour    //binaların / boruların hareketi
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject,5);           // oluşturulduktan 5 saniye sonra game objecti yok eder
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;           //binaları / boruları sola hareket ettirir.
    }
}


using UnityEngine;

public class Move : MonoBehaviour    //binalar�n / borular�n hareketi
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject,5);           // olu�turulduktan 5 saniye sonra game objecti yok eder
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;           //binalar� / borular� sola hareket ettirir.
    }
}


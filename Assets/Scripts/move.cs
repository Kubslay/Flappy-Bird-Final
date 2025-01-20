using UnityEngine;

public class Move : MonoBehaviour    //binalarýn / borularýn hareketi
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject,5);           // oluþturulduktan 5 saniye sonra game objecti yok eder
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;           //binalarý / borularý sola hareket ettirir.
    }
}


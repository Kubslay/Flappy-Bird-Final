using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour 
{
    public birdy BirdScript;


   // public float minY = 0;
   // public float maxY = 1;


    //public float height = 1;
    public GameObject Borular;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)                  // IEnumerator belli kodlar� d�zenli olarak belli saniye i�inde �al��t�rma�fonksiyonu
    {
        while (!BirdScript.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(0f, 1f), 0), Quaternion.identity);         // rastgele y ekseni 0 1 aral���nda 

            yield return new WaitForSeconds(time);                                                      // time a girilen s�re aral�klar�nda borular� spawnlar
        }
        
    }
}
 
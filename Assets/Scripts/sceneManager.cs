using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour                   //"game" ve "Start Menu" aras� ge�i�. 
{

    public void SahneyeGecis(int sahneIndeksi)                  //Butona bas�ld���nda buton 
    {                                                           //i�erisinden girdi�imiz indekse            
        SceneManager.LoadScene(sahneIndeksi);                   //sahip sahneye�y�nlendiren�kod.
    }
}

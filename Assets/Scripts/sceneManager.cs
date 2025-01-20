using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour                   //"game" ve "Start Menu" arasý geçiþ. 
{

    public void SahneyeGecis(int sahneIndeksi)                  //Butona basýldýðýnda buton 
    {                                                           //içerisinden girdiðimiz indekse            
        SceneManager.LoadScene(sahneIndeksi);                   //sahip sahneye yönlendiren kod.
    }
}

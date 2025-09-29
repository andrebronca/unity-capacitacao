using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene01_Button_Julia : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    public void ReturnScene01_Julia()
    {
       SceneManager.UnloadScene("Scene01");
       SceneManager.LoadScene("Scene01_Julia");
       Debug.Log("Scene trocada");
    }
}

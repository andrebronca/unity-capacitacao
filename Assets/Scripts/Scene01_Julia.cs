using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene01_Julia : MonoBehaviour
{
    void Start(){
        //TrocarScene();

    }
    public void TrocarScene()
    {
         SceneManager.LoadScene("Scene01");
         
        Debug.Log("Iniciando");
        
    }
}    
  

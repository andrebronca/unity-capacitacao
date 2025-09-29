using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarCena : MonoBehaviour
{
    // Start is called before the first frame update
    public void DescarregarCena()
    {

        SceneManager.UnloadScene("Scene01");
        SceneManager.LoadScene("Scene01_Poly");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

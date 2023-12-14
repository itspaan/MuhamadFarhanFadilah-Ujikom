using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string namascene;
    void Start()
    {

    }

    void Update()
    {

    }


    public void pindahScene()
    {
        SceneManager.LoadScene(namascene);
    }

}

  
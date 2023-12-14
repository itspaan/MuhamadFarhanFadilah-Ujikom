using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel;

    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            if (isPaused )
            {
                resumegame();
            }
            else
            {
                pausegame();
            }
        }

    }

    public void pausegame()
    {
        PausePanel.SetActive(true);
    }
    public void resumegame()
    {
        PausePanel.SetActive(false);
    }

}

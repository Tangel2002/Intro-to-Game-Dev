using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    bool isPaused = false;
    public GameObject pauseUI;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            togglePause();
        }
    }
    public void togglePause()
    {
        if (isPaused)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            
            Time.timeScale = 0;
            pauseUI.SetActive(true);
        }

        isPaused = !isPaused;
    }

    public void exit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource blip;
    public void LoadLevel(string name)
    {
        blip.Play();
        SceneManager.LoadScene(name);
        
    }
    public void Quit()
    {
        Application.Quit();
    }

    
}

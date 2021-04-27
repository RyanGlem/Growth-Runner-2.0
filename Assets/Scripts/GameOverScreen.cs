using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup (float score) {
        if (score == 0) {
            gameObject.SetActive(true); 
        }
    } 

    public void RestartButton () {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RestartBeginning () 
    {
        SceneManager.LoadScene ("SampleScene");
    }

    public void ExitButton() {
        SceneManager.LoadScene("MainMenu");
    }
}

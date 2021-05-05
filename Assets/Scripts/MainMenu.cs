using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    public void ExitButton() {
        Application.Quit();
        Debug.Log ("Game closed");
    }

    public void BackButton() {
        SceneManager.LoadScene ("MainMenu");
    }

    public void MathSelection() {
        SceneManager.LoadScene ("Level 0");
    }

    public void CapitalSelection() {
        SceneManager.LoadScene ("Level 3");
    }

    public void ScienceSelection() {
        SceneManager.LoadScene ("Level 6");
    }

    public void StartGame() {
        SceneManager.LoadScene("SelectionScreen");
    }
}

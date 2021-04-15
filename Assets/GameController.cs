using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public LivesController liveController;

    public void CompleteLevel () {
        SceneManager.LoadScene ("EndScreen");
    }

    public void LoadNextLevel () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameOver () 
    {
        float zeroLives = liveController.playerHealth;
        gameOverScreen.Setup(zeroLives);
    }

    void Update () {

        GameOver();
    }
}

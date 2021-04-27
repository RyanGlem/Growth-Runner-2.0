using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameController gameController;

    void OnTriggerEnter2D () 
    {
        gameController.LoadNextLevel();
    }
}

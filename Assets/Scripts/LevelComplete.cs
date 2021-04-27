using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameController gameController;

    void OnTriggerEnter2D () 
    {
        gameController.CompleteLevel();
    }
}

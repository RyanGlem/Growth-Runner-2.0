using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongAnswerScript : MonoBehaviour
{
    [SerializeField] private float incorrect;
    [SerializeField] private LivesController livesController;
    public Button wrongButton;

    public void ButtonClick() {

        livesController.playerHealth = livesController.playerHealth - incorrect;
        livesController.UpdateHealth();
        wrongButton.interactable = false;
        this.gameObject.SetActive (false); // Turns the button off so you can't select it again
        
    }
}

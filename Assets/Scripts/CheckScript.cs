using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour
{

    public Rigidbody2D rigid;
    public Animator animator;
    public Canvas canvas;
    public Canvas canvas2;

    void OnTriggerExit2D ()
    {
        GameObject[] btn = GameObject.FindGameObjectsWithTag("QuizButton");
        GameObject text = canvas.transform.Find("Question").gameObject;
        text.gameObject.SetActive (false);
        canvas2.gameObject.SetActive (true);

        foreach (GameObject button in btn)
        {
            button.gameObject.transform.Translate(-1000, 10, 10);
           
        }
        //Destroy (btn);
        //canvas.gameObject.SetActive(false);
        //canvas = GetComponentInChildren<Button>();
        //canvas.gameObject.SetActive(false);

    }
}

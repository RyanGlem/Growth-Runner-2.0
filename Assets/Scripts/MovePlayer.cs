using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    private Vector2 target;
    private Vector2 position;
    public Button quizButton;
    public Transform moveSpot;
    public Animator animator;
    public GameObject player;
    public float speed = 5.0f;
    public bool isEnabled = false;

    void Start () 
    {
        position = gameObject.transform.position;
        target = moveSpot.position;
    }

    void Update() {

        if (isEnabled) {

            rigid.position = Vector2.MoveTowards (rigid.position, moveSpot.position, speed * Time.deltaTime);
            if (rigid.position == target) {
                animator.SetInteger ("Direction", 0);
                isEnabled = !isEnabled;
            }
        }
    } 

    public void ButtonClicked() {
        isEnabled = !isEnabled;

        animator.SetInteger ("Direction", 1);
        Debug.Log ("MoveSpot: " + moveSpot.position);
        Debug.Log ("Transform Position: " + transform.position);
    }

}

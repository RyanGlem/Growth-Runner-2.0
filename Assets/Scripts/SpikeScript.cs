using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour
{

    [SerializeField] private float incorrect;
    [SerializeField] private LivesController livesController;
    [SerializeField] Rigidbody2D rigid;
    public Transform respawn;

    void OnTriggerEnter2D ()
    {
        rigid.position = respawn.position;
        livesController.playerHealth = livesController.playerHealth - incorrect;
        livesController.UpdateHealth();
    }
}

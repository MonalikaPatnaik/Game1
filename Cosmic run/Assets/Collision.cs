using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject thePlayer;
    public GameObject charModel;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = thePlayer.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        gameManager.gameOver();
        
        ;
    }
}

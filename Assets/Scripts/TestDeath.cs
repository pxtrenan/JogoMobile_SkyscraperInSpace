using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDeath : MonoBehaviour {

    public GameObject gameOver;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Platform"))
        {
            player.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
        
            
        }

    }
}

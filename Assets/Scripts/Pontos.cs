using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            LevelManager.levelManager.SetCoins();

            //som2.PlayOneShot(soundCoin);

        }

    }
}


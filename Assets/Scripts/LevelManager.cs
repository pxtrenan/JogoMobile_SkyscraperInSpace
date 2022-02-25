using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public static LevelManager levelManager;


    private int coinsAtual = 0;

    public Text coinsT;
    public Text coinsT2;
    public Text highScore;

    public AudioClip soundPoint;
    public AudioSource somPlayer;

    void Awake()
    {
       // somPlayer.ignoreListenerPause = true;

        if (levelManager == null)
        {
            levelManager = this;
        }
        else if (levelManager != this)
        {
            Destroy(gameObject);
        }


    }

    void Start()
    {
       highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void SetCoins()
    {
        coinsAtual++;
        coinsT.text = coinsAtual.ToString();
        coinsT2.text = coinsAtual.ToString();
        somPlayer.PlayOneShot(soundPoint);
        

        if (coinsAtual > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", coinsAtual);
            
        }

    }
    public int GetCoins()
    {
        return coinsAtual;
    }

    //Update is called once per frame
    void Update () {
		
	}
}

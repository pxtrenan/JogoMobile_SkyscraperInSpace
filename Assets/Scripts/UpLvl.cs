using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpLvl : MonoBehaviour
{

    public GameObject spawnLvl1;
    public GameObject spawnLvl2;
    public GameObject spawnUp1;
    public GameObject spawnUp2;
    public GameObject spawnLvl3;
    public GameObject spawnUp3;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Lvl1")
        {

            spawnLvl1.gameObject.SetActive(false);
            spawnLvl2.gameObject.SetActive(true);
            spawnUp1.gameObject.SetActive(false);
            spawnUp2.gameObject.SetActive(true);
            
        }

        if(other.tag == "Lvl2")
        {
            spawnLvl2.gameObject.SetActive(false);
            spawnLvl3.gameObject.SetActive(true);
            spawnUp2.gameObject.SetActive(false);
            spawnUp3.gameObject.SetActive(true);
        }
    }
}

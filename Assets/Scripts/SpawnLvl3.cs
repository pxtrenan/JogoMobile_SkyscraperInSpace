using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLvl3 : MonoBehaviour
{

    public GameObject objetoPrefab;
    public GameObject objetoPrefab2;
    public GameObject objetoPrefab3;
    public GameObject objetoPrefab4;
    public GameObject objetoPrefab5;
    public GameObject objetoPrefab6;
    public GameObject objetoPrefab7;
    public GameObject objetoPrefab8;

    private int number, temp = 0;



    private float rateSpawn;
    public float currentTime;

    private float y;




    // Use this for initialization
    void Start()
    {
        currentTime = 0;

    }

    // Update is called once per frame
    void Update()
    {



        rateSpawn = 1.20f;


        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;


            number = Random.Range(1, 9);

            while (temp == number)
            {
                number = Random.Range(1, 9);
            }

            temp = number;
            Debug.Log(number);

            if (number == 1)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 2)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab2) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 3)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab3) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 4)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab4) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 5)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab5) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 6)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab6) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 7)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab7) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 8)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab8) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }



    }

}


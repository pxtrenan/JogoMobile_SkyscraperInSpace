using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenu : MonoBehaviour
{


    public GameObject objetoPrefab;

    private int number;



    public float rateSpawn;
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
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;


            number = Random.Range(1, 2);


            Debug.Log(number);

            if (number == 1)
            {
                GameObject tempPrefab = Instantiate(objetoPrefab) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
        }
    }
}



    



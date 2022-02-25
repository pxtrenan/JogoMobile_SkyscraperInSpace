using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUp3 : MonoBehaviour
{

    public GameObject objetoPrefabUp3;



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



        rateSpawn = 10f;


        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;

            {
                GameObject tempPrefab = Instantiate(objetoPrefabUp3) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }



        }

    }

}

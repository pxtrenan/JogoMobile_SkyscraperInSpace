using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUp2 : MonoBehaviour
{

    public GameObject objetoPrefabUp2;



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



        rateSpawn = 15f;


        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;

            {
                GameObject tempPrefab = Instantiate(objetoPrefabUp2) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }



        }

    }

}

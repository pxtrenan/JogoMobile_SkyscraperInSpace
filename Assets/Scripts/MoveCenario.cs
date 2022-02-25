using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenario : MonoBehaviour
{
    private float speed;
    public float y;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        speed = -2.7f;
        y = transform.position.y;

        y += speed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, y, transform.position.z);

        if (y <= -8)
        {

            Destroy(transform.gameObject);
        }

    }

}
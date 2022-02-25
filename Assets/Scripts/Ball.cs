using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody2D playerRB;
    public float velocidade;
	// Use this for initialization
	void Start () {
        playerRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButtonDown(0))
        {
            velocidade = velocidade * -1;
        }

        playerRB.velocity = new Vector2(velocidade, playerRB.velocity.y);
	}
}

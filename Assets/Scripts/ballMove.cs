using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    public Rigidbody2D myRb;
    public float power;

    void Start()
    {
        myRb = gameObject.GetComponent<Rigidbody2D>();

    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRb.AddForce(Vector2.right * power);
        }
        
    }
}

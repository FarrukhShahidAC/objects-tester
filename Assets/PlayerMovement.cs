using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;

    public float forwardForce = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Hello World!!!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            // move right
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            // move right
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

    }
}

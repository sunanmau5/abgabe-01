using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnspeed;
    public float movespeed;

    // private Rigidbody rb;

    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        // If using rigidbody enable this comment
        // float moveVertical = Input.GetAxis("Vertical");
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // Get the horizontal and vertical axis
        float moveVertical = Input.GetAxis("Vertical") * movespeed;
        float moveHorizontal = Input.GetAxis("Horizontal") * movespeed;

        if (!MenuManagerScript.gameIsPaused)
        {
            // If using rigidbody enable this comment
            // Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
            // rb.AddForce(movement * movespeed);

            // Move translation along the object's z-axis
            transform.Translate(0.0f, 0.0f, moveVertical * Time.deltaTime);

            // Move translation along the object's x-axis
            transform.Translate(moveHorizontal * Time.deltaTime, 0.0f, 0.0f);

            if (Input.GetKey(KeyCode.E))
            {
                // Rotate around the y-axis clockwise
                transform.Rotate(transform.up * turnspeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                // Rotate around the y-axis counter clockwise
                transform.Rotate(-transform.up * turnspeed * Time.deltaTime);
            }
        }
    }
}

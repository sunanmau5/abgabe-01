using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float turnspeed = 100.0f;
    private float movespeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(0.0f, 0.0f, movespeed * moveVertical * Time.deltaTime);
        transform.Translate(movespeed * moveHorizontal * Time.deltaTime, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * turnspeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * turnspeed * Time.deltaTime);
        }
    }
}

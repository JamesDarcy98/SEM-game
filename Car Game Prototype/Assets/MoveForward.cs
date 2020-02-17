using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public Rigidbody2D rb;
    public float thrust = 2.0f;
    public float maxSpeed = 2.0f;
    public float maxY = 2.0f;
    public int CameFrom;
    public float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CameFrom = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            if (rb.velocity[0] < maxSpeed)
            {
                rb.velocity = new Vector3(rb.velocity[0] + 1f, rb.velocity[1], 0f);
            }

        }

        if (Input.GetKey(KeyCode.A))
         {
             if (rb.velocity[0] > -maxSpeed)
            {
              rb.velocity = new Vector3(rb.velocity[0] - 1f, rb.velocity[1], 0f);
            }

        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            if (rb.position[1] == 0 || rb.position[1] == -2)
            {
                rb.velocity = new Vector3(rb.velocity[0], 20f, 0f);
            }
            startTime = Time.time;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (rb.position[1] == 0 || rb.position[1] == 2)
            {
                rb.velocity = new Vector3(rb.velocity[0], -20f, 0f);
            }
            startTime = Time.time;
        }


        //Boundaries
        if (System.Math.Abs(rb.position[0]) > 11)
        {
            transform.position = new Vector3(11*System.Math.Sign(rb.position[0]), rb.position[1], 0.0f);
            rb.velocity = new Vector3(0f, rb.velocity[1], 0.0f);
        }

        if (System.Math.Abs(rb.position[1]) > 2)
        {
            transform.position = new Vector3(rb.position[0], 2 * System.Math.Sign(rb.position[1]), 0.0f);
            rb.velocity = new Vector3(rb.velocity[0], 0f, 0.0f);
            CameFrom = System.Math.Sign(rb.position[1]);
        }


        if (System.Math.Abs(rb.position[1]) < 0.05 && CameFrom != 0)
        {
            transform.position = new Vector3(rb.position[0], 0f, 0.0f);
            rb.velocity = new Vector3(rb.velocity[0], 0f, 0.0f);
            CameFrom = 0;
        } 

        if(System.Math.Abs(rb.position[1]) == 0)
        {
            if (Input.GetKey(KeyCode.S) && ((Time.time - startTime) > 0.3))
            {
                rb.velocity = new Vector3(rb.velocity[0], -20f, 0f);
            }

            if(Input.GetKey(KeyCode.W) && ((Time.time - startTime) > 0.3)){
                rb.velocity = new Vector3(rb.velocity[0], 20f, 0f);
            }
        }
      

       

    }
}

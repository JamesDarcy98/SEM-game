using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position[0] - 0.05f, transform.position[1], transform.position[2]);
        if(transform.position[0] < -20)
        {
            Destroy(gameObject);
        }
    }
}

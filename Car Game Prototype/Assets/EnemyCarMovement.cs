using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyCarMovement : MonoBehaviour
{


    private float carspeed;
    // Start is called before the first frame update
    void Start()
    {
        carspeed = Random.Range(0.05f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(transform.position[0] - carspeed, transform.position[1], transform.position[2]);
        if (transform.position[0] < -20)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    //Ignore this for now, its behaviour is horrible and I haven't got a chance to fix it properly
    public GameObject car;
    public Rigidbody2D carb;

    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        carb = car.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(((Time.deltaTime * 0.05f) + 10*carb.velocity[0]), 0);
        GetComponent<Renderer>().material.mainTextureOffset += offset;
    }
}

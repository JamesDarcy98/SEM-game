using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCollider : MonoBehaviour
{
    public FuelCounter counter;

    //When the car interacts with the fuel pickup, the object is destroyed and 50 is added to the fuel counter (see FuelCounter Script)
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Debug.Log("Destroyed");
        counter.FuelPickup();

    }

}

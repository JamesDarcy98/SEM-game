using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FuelCounter : MonoBehaviour
{
    public double FuelAmount;
    public GameOverState gameover;
    public Text FuelText;
    public double startTime;
    private GameObject car;
    private FuelCounter fuelcounter;
    // Start is called before the first frame update

    //Method Activates on collision with a fuel pickup (see FuelCollider script)
    public void FuelPickup()
    {
        car = GameObject.Find("car");
        fuelcounter = car.GetComponent<FuelCounter>();
        Debug.Log(FuelAmount);
        fuelcounter.FuelAmount += 50;
        //Debug.Log(FuelAmount);
    }

    //Initially sets Fuel to 100 and displays it on the text
    void Start()
    {
        car = GameObject.Find("car");
        fuelcounter = car.GetComponent<FuelCounter>();
        fuelcounter.FuelAmount = 100;
        FuelText.text = "Fuel: " + fuelcounter.FuelAmount;
        startTime = Time.time;
        
    }

    // Update is called once per frame
    // Reduces Fuel by an amount every frame and calls game over state when it reaches 0
    void Update()
    {
        //Debug.Log(FuelAmount);
        FuelAmount -= 0.01;
        if (FuelAmount <= 0)
        {
            gameover.GameOver();
        }
        else { FuelText.text = "Fuel: " + System.Math.Ceiling(FuelAmount); }

        
    }
}

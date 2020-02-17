using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text text;
    public double timeScore;
    public double startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = System.Math.Floor(Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        timeScore = System.Math.Floor(Time.time) - startTime;
        text.text = "Time: " + timeScore.ToString();
    }
}

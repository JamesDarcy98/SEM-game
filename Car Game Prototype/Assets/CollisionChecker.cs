using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionChecker : MonoBehaviour
{

    public Text TimerText;
    public Timer timer;
    public Image img;
    public Text txt;
    private bool isgameover;
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Timer timer = TimerText.GetComponent("Timer") as Timer;
        Debug.Log(timer.timeScore);
        img.enabled = true;
        txt.enabled = true;
        txt.text = "Game over! \nTime Lasted:  " + timer.timeScore.ToString() + "\n Press Space to Restart";
        isgameover = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        img.enabled = false;
        txt.enabled = false;
        Timer timer = TimerText.GetComponent("Timer") as Timer;

        Debug.Log(timer.timeScore);


    }

    // Update is called once per frame
    void Update()
    {
        
        if (isgameover && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
            //timer.startTime = System.Math.Floor(Time.time);

        }
    }
}

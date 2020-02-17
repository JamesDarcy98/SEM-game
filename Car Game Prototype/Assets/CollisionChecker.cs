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
    

    //Collision Checker - When Collision occurs, function below is called and the image and text constituting the Game Over Screen Appear
    //The other lines are to do with calling the Time spent in the game and displaying that as a score along with the game over screen;
    void OnCollisionEnter2D(Collision2D other)
    {
        Timer timer = TimerText.GetComponent("Timer") as Timer;
        img.enabled = true;
        txt.enabled = true;
        txt.text = "Game over! \nTime Lasted:  " + timer.timeScore.ToString() + "\n Press Space to Restart";
        isgameover = true;
    }

    // Start is called before the first frame update
    //Hides the Game over Text/Image until collision occurs (above)
    void Start()
    {
        img.enabled = false;
        txt.enabled = false;
    }

    // When the space button is pressed at on a Game Over Screen, the game restarts, as does the timer.
    void Update()
    {
        
        if (isgameover && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");

        }
    }
}

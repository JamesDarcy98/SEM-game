using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverState : MonoBehaviour
{
    public Text TimerText;
    public Timer timer;
    public Image img;
    public Text txt;
    private bool isgameover;
    public GameObject GameOverImage;
    public GameObject GameOverText;


    //function below is called on a game over state, and the image and text constituting the Game Over Screen Appear
    //The other lines are to do with calling the Time spent in the game and displaying that as a score along with the game over screen;
    public void GameOver()
    {
        if (isgameover == false)
        {
            Timer timer = TimerText.GetComponent("Timer") as Timer;
            GameOverImage.SetActive(true);
            GameOverText.SetActive(true);
            img.enabled = true;
            txt.enabled = true;
            txt.text = "Game over! \nTime Lasted:  " + timer.timeScore.ToString() + "\n Press Space to Restart";
            isgameover = true;
        }
        
    }

    // Start is called before the first frame update
    //Hides the Game over Text/Image until game over state is achieved (above)
    void Start()
    {

        img.enabled = false;
        txt.enabled = false;
        GameOverImage.SetActive(false);
        GameOverText.SetActive(false);
    }


    // Update is called once per frame
    // When the space button is pressed at on a Game Over Screen, the game restarts, as does the timer.
    void Update()
    {
        if (isgameover && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}

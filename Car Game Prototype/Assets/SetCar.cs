using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCar : MonoBehaviour
{

    public Sprite CarChoice1;
    public Sprite CarChoice2;
    public Sprite CarChoice3;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CarChoice is " + PlayerPrefs.GetInt("CarChoice"));
        if(PlayerPrefs.GetInt("CarChoice") == 2){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CarChoice2;
        } else if(PlayerPrefs.GetInt("CarChoice") == 3){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CarChoice3;
        } else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CarChoice1;
        }

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
     Debug.Log("CarChoice is " + PlayerPrefs.GetInt("CarChoice"));   
    }
}

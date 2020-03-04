using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiobg : MonoBehaviour
{
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        if (!source.isPlaying && Time.time == 0)
        {
            source.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

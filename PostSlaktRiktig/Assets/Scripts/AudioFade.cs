using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFade : MonoBehaviour
{
    public AudioSource music;
    bool isfading;
    // Start is called before the first frame update
    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isfading == true)
        {
            music.volume -= Time.deltaTime;
        }
    }
    public void FadeVolume()
    {
        isfading = true;
    }
}

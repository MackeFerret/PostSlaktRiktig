using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text TimerText;
    public static float Timer = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer < 0) Timer = 0;
        TimerText.text = "Time left: " + Mathf.Round(Timer);
        isDead();
    }
    public void isDead()
    {
        if (Timer == 0) Time.timeScale -= Time.deltaTime;
        if (Time.timeScale == 0) Time.timeScale = 0;
    }
}

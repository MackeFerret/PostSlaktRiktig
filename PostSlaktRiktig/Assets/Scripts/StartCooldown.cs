using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCooldown : MonoBehaviour
{
    public float Timer = 5;
    public Text timerText;
    public GameObject Countdown5s;
    public GameObject Countdown60s;
    public GameObject Music;
    // Start is called before the first frame update
    void Start()
    {
        Countdown5s.SetActive(true);
        Countdown60s.SetActive(false);
        Time.timeScale = 0;
        Music.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.unscaledDeltaTime;
        if (Mathf.Round(Timer) == -1)
        {
            Time.timeScale = 1;
        }
        timerText.text = "" + Mathf.Round(Timer -1);
        if(Mathf.Round(Timer) == 0)
        {
            timerText.text = "Go!";
        }
        if (Mathf.Round(Timer) < 0)
        {
            Countdown5s.SetActive(false);
            Countdown60s.SetActive(true);
            Music.SetActive(true);
        }
        if (Mathf.Round(Timer) == -10)
        {
            Timer = -10;
        }
    }
}

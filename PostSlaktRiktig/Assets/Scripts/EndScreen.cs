using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndScreen : MonoBehaviour
{
    public GameObject EndScreen1;
    public Countdown timer;

    void Start()
    {
        EndScreen1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Timer <= 0)
        {
            EndScreen1.SetActive(true);
        }
    }
}

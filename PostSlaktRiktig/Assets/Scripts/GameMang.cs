using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMang : MonoBehaviour
{
    public float Points;

    public Text pointText;
    public float houses;
    public float windows;

    public Text housesPoints;
    public Text windowsPoints;
    public Text totalPoints;

    void Start()
    {
        
    }

    
    void Update()
    {
        pointText.text = ("Points :" + Points).ToString();

        housesPoints.text = "You delivered " + houses + " packages!";
        windowsPoints.text = "You smashed " + windows + " windows in the process!";
        totalPoints.text = "Your total score was: " + windows + houses + "!";
    }

    public void PlusPoints()
    {
        Points++;
        Debug.Log("Test1");
        houses++;
    }
    public void PlusPointsPlus()
    {
        Points++;
        Points++;
        Debug.Log("Test2");
        windows++;
    }
}

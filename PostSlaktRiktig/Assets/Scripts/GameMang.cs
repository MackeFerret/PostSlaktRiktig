using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMang : MonoBehaviour
{
    public float Points;

    public Text pointText;

    void Start()
    {
        
    }

    
    void Update()
    {
        pointText.text = ("Points :" + Points).ToString();
    }

    public void PlusPoints()
    {
        Points++;
        Debug.Log("Test1");
    }
    public void PlusPointsPlus()
    {
        Points++;
        Points++;
        Debug.Log("Test2");
    }
}

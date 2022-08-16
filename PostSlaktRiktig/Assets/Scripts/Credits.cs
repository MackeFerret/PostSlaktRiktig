using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject credCar;
    public GameObject ljudeffekter;
    // Start is called before the first frame update
    void Start()
    {
        credCar.SetActive(false);
        ljudeffekter.SetActive(false);
        Invoke("creditcar", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void creditcar()
    {
        credCar.SetActive(true);
        ljudeffekter.SetActive(true);
    }
}

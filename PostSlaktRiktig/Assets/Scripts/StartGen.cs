using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGen : MonoBehaviour
{
    [SerializeField] GameObject Map1;
    [SerializeField] GameObject Map2;
    [SerializeField] GameObject Map3;
    [SerializeField] GameObject Map4;
    [SerializeField] GameObject Map5;
    [SerializeField] GameObject Map6;
    [SerializeField] GameObject Map7;
    [SerializeField] GameObject Map8;

    public Transform mapCenter;

    // Start is called before the first frame update
    void Start()
    {
        float rng = Random.Range(0, 8);
        if (rng == 0)
        {
            Instantiate(Map1, mapCenter);
        }
        else if (rng == 1)
        {
            Instantiate(Map2, mapCenter);
        }
        else if (rng == 2)
        {
            Instantiate(Map3, mapCenter);
        }
        else if (rng == 3)
        {
            Instantiate(Map4, mapCenter);
        }
        else if (rng == 4)
        {
            Instantiate(Map5, mapCenter);
        }
        else if (rng == 5)
        {
            Instantiate(Map6, mapCenter);
        }
        else if (rng == 6)
        {
            Instantiate(Map7, mapCenter);
        }
        else if (rng == 7)
        {
            Instantiate(Map8, mapCenter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

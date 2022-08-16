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
    public Transform mapLeft;
    public Transform mapRight;
    public Transform mapUp;
    public Transform mapDown;
    public Transform mapUpLeft;
    public Transform mapUpRight;
    public Transform mapDownLeft;
    public Transform mapDownRight;

    // Start is called before the first frame update
    void Start()
    {
        float rng = Random.Range(0, 7);
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
            Instantiate(Map4, mapCenter);
        }
        else if (rng == 3)
        {
            Instantiate(Map5, mapCenter);
        }
        else if (rng == 4)
        {
            Instantiate(Map6, mapCenter);
        }
        else if (rng == 5)
        {
            Instantiate(Map7, mapCenter);
        }
        else if (rng == 6)
        {
            Instantiate(Map8, mapCenter);
        }
        float rng2 = Random.Range(0, 7);
        if (rng2 == 0)
        {
            Instantiate(Map1, mapRight);
        }
        else if (rng2 == 1)
        {
            Instantiate(Map2, mapRight);
        }
        else if (rng2 == 2)
        {
            Instantiate(Map4, mapRight);
        }
        else if (rng2 == 3)
        {
            Instantiate(Map5, mapRight);
        }
        else if (rng2 == 4)
        {
            Instantiate(Map6, mapRight);
        }
        else if (rng2 == 5)
        {
            Instantiate(Map7, mapRight);
        }
        else if (rng2 == 6)
        {
            Instantiate(Map8, mapRight);
        }
        else if (rng2 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
        float rng3 = Random.Range(0, 7);
        if (rng3 == 0)
        {
            Instantiate(Map1, mapUpRight);
        }
        else if (rng3 == 1)
        {
            Instantiate(Map2, mapUpRight);
        }
        else if (rng3 == 2)
        {
            Instantiate(Map4, mapUpRight);
        }
        else if (rng3 == 3)
        {
            Instantiate(Map5, mapUpRight);
        }
        else if (rng3 == 4)
        {
            Instantiate(Map6, mapUpRight);
        }
        else if (rng3 == 5)
        {
            Instantiate(Map7, mapUpRight);
        }
        else if (rng3 == 6)
        {
            Instantiate(Map8, mapUpRight);
        }
        else if (rng3 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
        float rng4 = Random.Range(0, 7);
        if (rng4 == 0)
        {
            Instantiate(Map1, mapDownRight);
        }
        else if (rng4 == 1)
        {
            Instantiate(Map2, mapDownRight);
        }
        else if (rng4 == 2)
        {
            Instantiate(Map4, mapDownRight);
        }
        else if (rng4 == 3)
        {
            Instantiate(Map5, mapDownRight);
        }
        else if (rng4 == 4)
        {
            Instantiate(Map6, mapDownRight);
        }
        else if (rng4 == 5)
        {
            Instantiate(Map7, mapDownRight);
        }
        else if (rng4 == 6)
        {
            Instantiate(Map8, mapDownRight);
        }
        else if (rng4 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
        float rng5 = Random.Range(0, 7);
        if (rng5 == 0)
        {
            Instantiate(Map1, mapUp);
        }
        else if (rng5 == 1)
        {
            Instantiate(Map2, mapUp);
        }
        else if (rng5 == 2)
        {
            Instantiate(Map4, mapUp);
        }
        else if (rng5 == 3)
        {
            Instantiate(Map5, mapUp);
        }
        else if (rng5 == 4)
        {
            Instantiate(Map6, mapUp);
        }
        else if (rng5 == 5)
        {
            Instantiate(Map7, mapUp);
        }
        else if (rng5 == 6)
        {
            Instantiate(Map8, mapUp);
        }
        else if (rng5 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
        float rng6 = Random.Range(0, 7);
        if (rng6 == 0)
        {
            Instantiate(Map1, mapDown);
        }
        else if (rng6 == 1)
        {
            Instantiate(Map2, mapDown);
        }
        else if (rng6 == 2)
        {
            Instantiate(Map4, mapDown);
        }
        else if (rng6 == 3)
        {
            Instantiate(Map5, mapDown);
        }
        else if (rng6 == 4)
        {
            Instantiate(Map6, mapDown);
        }
        else if (rng6 == 5)
        {
            Instantiate(Map7, mapDown);
        }
        else if (rng6 == 6)
        {
            Instantiate(Map8, mapDown);
        }
        else if (rng6 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
        float rng7 = Random.Range(0, 7);
        if (rng7 == 0)
        {
            Instantiate(Map1, mapLeft);
        }
        else if (rng7 == 1)
        {
            Instantiate(Map2, mapLeft);
        }
        else if (rng7 == 2)
        {
            Instantiate(Map4, mapLeft);
        }
        else if (rng7 == 3)
        {
            Instantiate(Map5, mapLeft);
        }
        else if (rng7 == 4)
        {
            Instantiate(Map6, mapLeft);
        }
        else if (rng7 == 5)
        {
            Instantiate(Map7, mapLeft);
        }
        else if (rng7 == 6)
        {
            Instantiate(Map8, mapLeft);
        }
        else if (rng7 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
        float rng8 = Random.Range(0, 7);
        if (rng8 == 0)
        {
            Instantiate(Map1, mapUpLeft);
        }
        else if (rng8 == 1)
        {
            Instantiate(Map2, mapUpLeft);
        }
        else if (rng8 == 2)
        {
            Instantiate(Map4, mapUpLeft);
        }
        else if (rng8 == 3)
        {
            Instantiate(Map5, mapUpLeft);
        }
        else if (rng8 == 4)
        {
            Instantiate(Map6, mapUpLeft);
        }
        else if (rng8 == 5)
        {
            Instantiate(Map7, mapUpLeft);
        }
        else if (rng8 == 6)
        {
            Instantiate(Map8, mapUpLeft);
        }
        else if (rng8 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
        float rng9 = Random.Range(0, 7);
        if (rng9 == 0)
        {
            Instantiate(Map1, mapDownLeft);
        }
        else if (rng9 == 1)
        {
            Instantiate(Map2, mapDownLeft);
        }
        else if (rng9 == 2)
        {
            Instantiate(Map4, mapDownLeft);
        }
        else if (rng9 == 3)
        {
            Instantiate(Map5, mapDownLeft);
        }
        else if (rng9 == 4)
        {
            Instantiate(Map6, mapDownLeft);
        }
        else if (rng9 == 5)
        {
            Instantiate(Map7, mapDownLeft);
        }
        else if (rng9 == 6)
        {
            Instantiate(Map8, mapDownLeft);
        }
        else if (rng9 == 7)
        {
            Instantiate(Map3, mapDownLeft);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

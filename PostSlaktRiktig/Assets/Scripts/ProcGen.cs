using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGen : MonoBehaviour
{
    [SerializeField] GameObject Map1;
    [SerializeField] GameObject Map2;
    [SerializeField] GameObject Map3;
    [SerializeField] GameObject Map4;
    [SerializeField] GameObject Map5;
    [SerializeField] GameObject Map6;
    [SerializeField] GameObject Map7;
    [SerializeField] GameObject Map8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            float rng = Random.Range(0, 8);
            if (rng == 0)
            {
                Instantiate(Map1);
            }
            else if (rng == 1)
            {
                Instantiate(Map2);
            }
            else if (rng == 2)
            {
                Instantiate(Map3);
            }
            else if (rng == 3)
            {
                Instantiate(Map4);
            }
            else if (rng == 4)
            {
                Instantiate(Map5);
            }
            else if (rng == 5)
            {
                Instantiate(Map6);
            }
            else if (rng == 6)
            {
                Instantiate(Map7);
            }
            else if (rng == 7)
            {
                Instantiate(Map8);
            }
        }
    }
}

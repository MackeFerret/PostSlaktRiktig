using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public GameObject everything;
    public GameObject noteverything;
    public GameObject noteverything2;
    // Start is called before the first frame update
    void Start()
    {
        everything.SetActive(false);
        Invoke("literallyeverything", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void literallyeverything()
    {
        everything.SetActive(true);
        noteverything.SetActive(false);
        noteverything2.SetActive(false);
    }
}

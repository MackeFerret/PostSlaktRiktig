using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    public GameObject shutter1;
    public GameObject shutter2;
    public GameObject loading;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shutterplay()
    {
        shutter1.SetActive(true);
        shutter2.SetActive(true);
        loading.SetActive(true);
    }
}

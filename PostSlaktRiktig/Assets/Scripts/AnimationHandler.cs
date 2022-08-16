using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    public GameObject shutter1;
    public GameObject shutter2;
    public GameObject loading;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        shutter1.SetActive(false);
        shutter2.SetActive(false);
        loading.SetActive(false);
        panel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shutterplay()
    {
        panel2.SetActive(true);
        Invoke("ignoreininspector", 2);
    }
    public void ignoreininspector()
    {
        shutter1.SetActive(true);
        shutter2.SetActive(true);
        loading.SetActive(true);
    }
}

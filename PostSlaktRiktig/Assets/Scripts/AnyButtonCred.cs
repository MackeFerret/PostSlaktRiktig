using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyButtonCred : MonoBehaviour
{
    public GameObject anyButton;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backButton()
    {
        Invoke("backButtonDelay", 5);
    }
    void backButtonDelay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 1f;

    private Transform tra;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        tra = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.W)))
        {
            rb.AddTorque(-0.05f, ForceMode2D.Impulse);  //roterar rigidbodyn
            //tra.Rotate(0, 0, -5);
        }
        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.W)))
        {
             rb.AddTorque(0.05f, ForceMode2D.Impulse); //roterar rigidbodyn
            //tra.Rotate(0, 0, 5);
        }
    }

}

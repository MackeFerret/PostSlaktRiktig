using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soptunna : MonoBehaviour
{
    public bool hit = false;
    Rigidbody2D rb;

    public float tipSpeed = 5f;

    [SerializeField] Transform Player;
    private Rigidbody2D rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<Movement>().gameObject.transform;
        rbPlayer = Player.GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hit == true) { GetComponent<BoxCollider2D>().enabled = false; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hit == false)
        {
            rb.AddForce(rbPlayer.velocity.normalized * tipSpeed, ForceMode2D.Impulse);
            hit = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{
    public bool hit = false;
    Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;
    public Sprite Broken;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hit == true) { GetComponent<BoxCollider2D>().enabled = false; spriteRenderer.sprite = Broken; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hit == false)
        {
            hit = true;
        }
    }
}

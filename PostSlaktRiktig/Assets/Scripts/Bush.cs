using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public bool hit = false;

    public SpriteRenderer spriteRenderer;
    public Sprite Broken1;
    public Sprite Broken2;
    public Sprite Broken3;
    public Sprite Broken4;
    public Sprite Broken5;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && hit == false)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            float rng = Random.Range(0, 6);
            if (rng == 0)
            {
                spriteRenderer.sprite = Broken1;
            }
            else if (rng == 1)
            {
                spriteRenderer.sprite = Broken2;
            }
            else if (rng == 2)
            {
                spriteRenderer.sprite = Broken3;
            }
            else if (rng == 3)
            {
                spriteRenderer.sprite = Broken4;
            }
            else if (rng == 4)
            {
                spriteRenderer.sprite = Broken5;
            }
            hit = true;
        }
    }
}
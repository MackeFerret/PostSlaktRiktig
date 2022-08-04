using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPacketSelector : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite0;
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
    public Sprite newSprite5;
    public Sprite newSprite6;
    public Sprite newSprite7;

    int change = 1;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (change == 1)
            {
            float rng = Random.Range(0, 8);
                if (rng == 0)
                {
                    spriteRenderer.sprite = newSprite0;
                }
                else if (rng == 1)
                {
                    spriteRenderer.sprite = newSprite1;
                }
                else if (rng == 2)
                {
                    spriteRenderer.sprite = newSprite2;
                }
                else if (rng == 3)
                {
                    spriteRenderer.sprite = newSprite3;
                }
                else if (rng == 4)
                {
                    spriteRenderer.sprite = newSprite4;
                }
                else if (rng == 5)
                {
                    spriteRenderer.sprite = newSprite5;
                }
                else if (rng == 6)
                {
                    spriteRenderer.sprite = newSprite6;
                }
                else if (rng == 7)
                {
                    spriteRenderer.sprite = newSprite7;
                }
            }
        }
    }
}

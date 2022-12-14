using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ammo;
    public GameObject house;

    public float bulletForce = 20f; //how fast bullet goes
    private float reload = 0; //when reload = 1, can shoot
    public float timer = 0; //counts second(s) til reload = 1
    Rigidbody2D rb;

    Vector2 mousePos;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When reload = 1 you are able to spawn ammo
        if (Input.GetButton("Fire1") && reload == 1)
        {
            GameObject bullet = Instantiate(ammo, firePoint.position, firePoint.rotation);
            Rigidbody2D rbullet = bullet.GetComponent<Rigidbody2D>();
            rbullet.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            reload = 0;
            Destroy(bullet, 15);
        }
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 0;
            if (Input.GetButton("Fire1"))
            {
                reload = 1;
                timer = 1;
            }
        }
    }
}

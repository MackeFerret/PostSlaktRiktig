using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HouseScript : MonoBehaviour
{

    public UnityEvent onDelivering;
    public UnityEvent hasDelivered;

    bool Delivery = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Packet") && Delivery == true)
        {
            onDelivering.Invoke();
            Delivery = false;
        }
        else if(Delivery == false)
        {
            hasDelivered.Invoke();
        }
    }
}

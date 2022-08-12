using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HouseScript : MonoBehaviour
{

    public UnityEvent onDelivering;
    public UnityEvent hasDelivered;

    public bool Delivery = true;
    GameMang gameManager;

    Animator DeliveryIcon;

    private void Start()
    {
        this.gameManager = GameObject.FindObjectOfType<GameMang>();
        this.DeliveryIcon = GetComponentInChildren<Animator>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Packet") && Delivery == true)
        {
            onDelivering.Invoke();
            this.gameManager.PlusPoints();
            Delivery = false;
            this.DeliveryIcon.gameObject.SetActive(false);
            
        }
        else if(Delivery == false)
        {
            
            hasDelivered.Invoke();
        }
    }
}

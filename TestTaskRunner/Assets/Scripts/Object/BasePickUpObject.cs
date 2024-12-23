using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePickUpObject : MonoBehaviour
{
    [SerializeField] float price;
    delegate void PickUp(float num);
    event PickUp pickUp;
    private void Start()
    {
        pickUp += GameManager.Instance.ChangeSum;
    }

    private void OnCollisionEnter(Collision collision)
    {
        pickUp.Invoke(price);
        pickUp -= GameManager.Instance.ChangeSum;
        Destroy(gameObject);
    }

}

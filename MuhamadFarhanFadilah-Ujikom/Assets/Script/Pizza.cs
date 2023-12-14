using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward* speed;
    }


    /*private void OnTriggerEnter(Collider other)
    {
        Animal animal = other.GetComponent<Animal>();
        if (animal != null)
        {
            animal.takedamage(20);
        }
        Destroy(gameObject);
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}

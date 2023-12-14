using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{



    public Transform shootingPoint;
    public GameObject pizzaprefab;
    public float speed;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(pizzaprefab,shootingPoint.position,transform.rotation);
        }
    }


    void move ()
    {
        float movement = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * movement * speed;
    }
}

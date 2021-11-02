using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed;
    public float rotationSpeed;

    private float hor;
    private float ver;
    private Vector3 moveVector;
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");

        moveVector = new Vector3(hor, 0, ver);

        if (moveVector != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveVector), rotationSpeed * Time.deltaTime);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = moveVector.normalized * movementSpeed;
    }
}

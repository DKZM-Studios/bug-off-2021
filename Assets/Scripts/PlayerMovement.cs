using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cam;
    public float movementSpeed;
    public float rotationSpeed;

    private float hor;
    private float ver;
    private Vector3 moveDir;
    private Vector3 direction;

    void Start()
    {
        CursorManager.Instance.LockCursor();
    }
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");

        direction = new Vector3(hor, 0f, ver).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, targetAngle, 0f), rotationSpeed * Time.deltaTime);

            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        }
    }
    void FixedUpdate()
    {
        if (direction.magnitude >= 0.1f)
            rb.velocity = new Vector3(moveDir.x * movementSpeed, rb.velocity.y, moveDir.z * movementSpeed);
    }
}

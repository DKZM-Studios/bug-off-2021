using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode jetpackKey = KeyCode.Space;
    public float movementSpeed;
    public float jetpackForce;
    public ParticleSystem jetpackParticles;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(jetpackKey))
            jetpackParticles.Play();
        if (Input.GetKeyUp(jetpackKey))
            jetpackParticles.Stop();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(jetpackKey))
            rb.AddForce(Vector2.up * jetpackForce);

        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * movementSpeed, rb.velocity.y);
    }
}

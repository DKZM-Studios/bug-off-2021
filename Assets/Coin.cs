using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float waveHeight;
    public float waveSpeed;
    public float rotationSpeed;
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + (waveHeight * Mathf.Sin(waveSpeed * Time.time)) * 0.0001f);
    }
}

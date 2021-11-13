using UnityEngine;

public class Player : MonoBehaviour
{
    public static int coinCount { get; private set; }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(other.gameObject);
        }
    }
}

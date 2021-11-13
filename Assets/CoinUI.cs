using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    public Text coinCountText;
    void Update()
    {
        coinCountText.text = Player.coinCount.ToString();
    }
}

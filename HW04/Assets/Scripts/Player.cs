using UnityEngine;

public class Player : MonoBehaviour
{
    public CoinManeger CoinManeger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            CoinManeger.CollectCoin(other.GetComponent<Coin>());
        }
    }
}

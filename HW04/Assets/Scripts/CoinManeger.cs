using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManeger : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private List<Coin> _coinsList = new List<Coin>();
    [SerializeField] private Text _coinsText;
    [SerializeField] private int _maxCoinGenerate = 50;
    [SerializeField] private float _maxRangePosition = 20f;
    [SerializeField] private float _minRangePosition = -20f;
    [SerializeField] private float _coinPositionY = 0.5f;


    private void Start()
    {
        GenerateCoins();

        UpdateText();
    }

    private void UpdateText()
    {
        _coinsText.text = _coinsList.Count.ToString();
    }

    private void GenerateCoins()
    {
        for (int i = 0; i < _maxCoinGenerate; i++)
        {
            Vector3 position = new Vector3(Random.Range(_minRangePosition, _maxRangePosition), _coinPositionY, Random.Range(_minRangePosition, _maxRangePosition));
            GameObject newCoin = Instantiate(_coinPrefab, position, Quaternion.identity);
            _coinsList.Add(newCoin.GetComponent<Coin>());
        }
    }

    public void CollectCoin(Coin coin)
    {
        _coinsList.Remove(coin);

        Destroy(coin.gameObject);

        UpdateText();
    }

    public Coin GetClosest(Vector3 point)
    {
        float minDistans = Mathf.Infinity;
        Coin closesCoin = null;

        for (int i = 0; i < _coinsList.Count; i++)
        {
            float distans = Vector3.Distance(point, _coinsList[i].transform.position);

            if (distans < minDistans)
            {
                minDistans = distans;
                closesCoin = _coinsList[i];
            }
        }

        return closesCoin;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCoin : MonoBehaviour
{
    public GameObject[] coinPrefab;
    public float respawnTime = 1;
    public int Random_coin ;

    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        CoinCalculator.coinAmount = 0;
        StartCoroutine(coinWave());    
    }

    private void spawnCoin()
    {
            Random_coin = (int)Random.Range(0, 3);
            GameObject obj = Instantiate(coinPrefab[Random_coin]) as GameObject;
            obj.transform.position = new Vector2(9, -3.7f);
    }

    IEnumerator coinWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCoin();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

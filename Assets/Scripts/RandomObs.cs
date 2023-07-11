using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObs : MonoBehaviour
{
    [SerializeField] private GameObject obsPrefab;
    [SerializeField] private GameObject[] spawnPoints;

    private float timer = 6f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(3, 8);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<=0)
        {
            GameObject temp = Instantiate(obsPrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
            timer = Random.Range(3, 8);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}

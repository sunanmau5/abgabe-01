using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{
    public Transform myPrefab;
    private int count, amount;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        amount = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        float spawnPosX = Random.Range(-5.0f, 5.0f);
        float spawnPosZ = Random.Range(-5.0f, 5.0f);
        if (count != amount)
        {
            Vector3 spawnPos = new Vector3(spawnPosX, 0.0f, spawnPosZ);
            Instantiate(myPrefab, spawnPos, Quaternion.Euler(0, Random.Range(0, 180), 0));
            count++;
        }
    }
}

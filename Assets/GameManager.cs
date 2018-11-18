using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private EnemyPooling pooling;

    public float minSpawnTime;
    public float maxSpawnTime;

    private float time;

    void Start () {
        pooling = EnemyPooling.enemyPooling;
        time = Random.Range(minSpawnTime, maxSpawnTime);

    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            pooling.TakeFromQueue().SetActive(true);
            time = Random.Range(minSpawnTime, maxSpawnTime);

        }
	}
}

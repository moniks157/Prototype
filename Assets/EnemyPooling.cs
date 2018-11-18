using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour {

    public static EnemyPooling enemyPooling;

    private Queue<GameObject> enemyPool;

    public int capacity;
    public GameObject enemy;

    private void Awake()
    {
        enemyPooling = this;
    }

    void Start () {


        enemyPool = new Queue<GameObject>();

        for (int i = 0; i < capacity; i++)
        {
            GameObject obj = GameObject.Instantiate(enemy);
            enemyPool.Enqueue(obj);
            obj.SetActive(false);
        }
	}
    
    public void ReturnToQueue(GameObject enemy)
    {
        enemy.SetActive(false);
        enemyPool.Enqueue(enemy);
    }

    public GameObject TakeFromQueue()
    {
        GameObject obj = enemyPool.Dequeue();
        return obj;
    }
}

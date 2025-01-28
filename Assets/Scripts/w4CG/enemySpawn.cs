using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public int enemyCount;
    void Start()
    {
        for (float i = 0; i < enemyCount; i++)
        {
            Instantiate(enemy, new Vector2(-6+(i*3),0), Quaternion.identity);
        }
        enemy.SetActive(false);
    }
}

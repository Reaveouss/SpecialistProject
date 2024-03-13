using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawning : MonoBehaviour
{
    [SerializeField] GameObject Enemy1;
    [SerializeField] GameObject Enemy2;
    [SerializeField] GameObject Enemy3;
    [SerializeField] GameObject Player;
    public int spawnRadius = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy(int amount)
    {
        while (amount != 0)
        {
            Vector2 randomPos = Random.insideUnitCircle * spawnRadius;
            Vector3 spawnPos = Player.transform.position + new Vector3(randomPos.x, randomPos.y, 0);
            int EnemySelect = Random.Range(0, 3) + 1;
            Debug.Log(EnemySelect);
            if (EnemySelect == 1)
            {
                Instantiate(Enemy1);
                Enemy1.transform.position = spawnPos;
            }
            if (EnemySelect == 2)
            {
                Instantiate(Enemy2);
                Enemy2.transform.position = spawnPos;
            }
            if (EnemySelect == 3)
            {
                Instantiate(Enemy3);
                Enemy3.transform.position = spawnPos;
            }
            amount--;
        }
    }
}

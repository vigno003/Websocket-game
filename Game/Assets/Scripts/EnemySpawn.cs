using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    //float repeatTime = 3f;
    //Random repeateTime = new Random();

    private void Start()
    {
        InvokeRepeating("Spawn", 2f, Random.Range(3f, 10f));
    }

    void Spawn()
    {
        if (Enemy == null)
        {
            return;
        }
        Instantiate(Enemy, transform.position, Quaternion.identity);              
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
     public GameObject Enemy;
     float repeatTime = 3f;

    private void Start()
    {
        InvokeRepeating("Spawn", 2f, repeatTime);
    }

    void Spawn()
    {
        if (Enemy!=null)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
        else
        {
            
        }
    }
}

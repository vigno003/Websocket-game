using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacks : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Destroy(other.gameObject);
        }
        else if (other.tag=="Bullet")
        {
            Destroy(gameObject);
        }
    }
}

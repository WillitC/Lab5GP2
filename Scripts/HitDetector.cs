using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("swin");
        if (other.CompareTag("Enemy"))
        {
            print("Hit");
            EnemyController enemyController = other.GetComponent<EnemyController>();
            if (enemyController != null)
            {
                enemyController.GotHit();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Enemies dies on hitting projectile
 */

public class EnemyOnCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Projectile")
        {
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }
}

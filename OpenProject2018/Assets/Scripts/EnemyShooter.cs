using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This guy shoots back. Very dangerous.
 */

public class EnemyShooter : Enemy
{
    private float attackCooldown = 0.7f;
    public GameObject projectile;
    public float bulletSpeed = 5f;

    public override void Start()
    {
        base.Start();
        InvokeRepeating("ShootProjectile", 0, attackCooldown);
    }

    private void ShootProjectile()
    {
        Vector3 direction = Vector3.down;
        Vector3 spawnOffset = direction * 1f;
        Vector3 spawnPosition = transform.position + spawnOffset;
        GameObject bullet = Instantiate(projectile, spawnPosition, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }

}

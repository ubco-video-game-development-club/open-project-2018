using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    /// <summary>
    /// Rigidbody velocity of the player.
    /// </summary>
    [Header("Player Options")]
    public float movementSpeed = 1f;
    /// <summary>
    /// Minimum time delay between firing bullets.
    /// </summary>
    public float attackCooldown = 0;

    private float attackTimer = 0;

    /// <summary>
    /// Bullet prefab to be spawned by the player when firing bullets.
    /// </summary>
    [Header("Bullet Options")]
    public GameObject bulletPrefab;
    /// <summary>
    /// Rigidbody velocity of the bullet.
    /// </summary>
    public float bulletSpeed = 1f;
    /// <summary>
    /// Distance from the player that bullets will spawn.
    /// </summary>
    public float bulletSpawnDistance = 1f;

	private void Start()
    {
		
	}
	
	private void FixedUpdate()
    {
        Move();

        attackTimer += Time.deltaTime;
        if (Input.GetButton("Fire1") && attackTimer > attackCooldown)
        {
            Shoot();
            attackTimer = 0;
        }
	}

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(x * movementSpeed, y * movementSpeed);
    }

    private void Shoot()
    {
        Vector3 direction = Vector3.up;
        Vector3 spawnOffset = direction * bulletSpawnDistance;
        Vector3 spawnPosition = transform.position + spawnOffset;
        GameObject bullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}

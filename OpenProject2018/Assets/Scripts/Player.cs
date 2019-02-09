using UnityEngine;

public class Player : MonoBehaviour {
    
    /// <summary>
    /// Rigidbody velocity of the player.
    /// </summary>
    [Header("Player Options")]
    public float movementSpeed = 1f;
    public float acceleration = 0.2f;
    public float damping = 0.8f;
    /// <summary>
    /// Minimum time delay between firing bullets.
    /// </summary>
    public float attackCooldown = 0;
    
    private float attackTimer = 0;

    /// <summary>
    /// Basic player stats
    /// </summary>
    public float health = 100f;
    public float armor = 2f;

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

    private Rigidbody2D rb;
    private Vector2 movementVelocity;
    private float xDir = 0f;
    private float yDir = 0f;
    private float speedModifier = 1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //Get rigidbody of player for movement
    }
	
	private void FixedUpdate()
    {
        Move();

        attackTimer += Time.deltaTime;

        //Prevent attackTimer from going too high
        if(attackTimer > attackCooldown + 1)    
        {
            attackTimer = attackCooldown + 1;
        }

        if (Input.GetButton("Fire1") && attackTimer > attackCooldown)
        {
            Shoot();
            attackTimer = 0;
        }

	}

    private void Move()
    {
        xDir = Input.GetAxisRaw("Horizontal");
        yDir = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedModifier = 0.5f;
        }
        else
        {
            speedModifier = 1f;
        }

        movementVelocity.x = xDir * movementSpeed * speedModifier;
        movementVelocity.y = yDir * movementSpeed * speedModifier;

        rb.velocity = movementVelocity;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Player dies on hitting projectile
 */

public class PlayerOnCollision : MonoBehaviour
{
    Renderer playerRenderer;
    CircleCollider2D playerCollider;
    public float respawnTimer = 2f;

    private void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        playerCollider = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Hides player and disable hitbox, then put the player back after respawnTimer seconds
        if (collider.gameObject.tag == "Enemies" | collider.gameObject.tag == "EnemyProjectile")
        {
            Destroy(collider.gameObject);
            playerRenderer.enabled = false;
            playerCollider.enabled = false;
            Invoke("RespawnPlayer", respawnTimer);
        }
    }

    void RespawnPlayer()
    {
        transform.position = new Vector2(0, -8);
        playerRenderer.enabled = true;
        playerCollider.enabled = true;
    }
}

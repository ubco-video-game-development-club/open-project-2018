using UnityEngine;

public class EnemySpawnAction : EnemyAction
{
    /// <summary>
    /// World position the enemy will spawn at.
    /// </summary>
    public Vector3 spawnPosition;

    public override void Init(GameObject enemy)
    {
        return;
    }

    /// <summary>
    /// Spawn function. Returns true when the enemy has spawned.
    /// </summary>
    public override bool Run(GameObject enemy)
    {
        enemy.transform.position = spawnPosition;
        isCompleted = true;

        return isCompleted;
    }
}

using UnityEngine;

public class EnemyIdleAction : EnemyAction
{
    /// <summary>
    /// Total time the enemy will stay idle.
    /// </summary>
    public float idleDuration;

    /// <summary>
    /// Timer of how long the enemy has been idle.
    /// </summary>
    private float idleTimer = 0;

    public override void Init(GameObject enemy)
    {
        idleTimer = 0;
    }

    /// <summary>
    /// Idle function. Returns true if enemy has been idle for the full duration.
    /// </summary>
    public override bool Run(GameObject enemy)
    {
        idleTimer += Time.deltaTime;
        
        if (idleTimer > idleDuration)
        {
            isCompleted = true;
        }

        return isCompleted;
    }
}

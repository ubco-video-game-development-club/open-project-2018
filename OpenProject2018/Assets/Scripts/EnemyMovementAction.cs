using UnityEngine;

public class EnemyMovementAction : EnemyAction {
    
    /// <summary>
    /// World position the enemy will move towards.
    /// </summary>
    public Vector3 targetPosition;
    /// <summary>
    /// Total time required to move between two points on the path at the defined movementSpeed.
    /// </summary>
    public float moveDuration = 1f;

    /// <summary>
    /// World position of the enemy when it started moving.
    /// </summary>
    private Vector3 startPosition;
    /// <summary>
    /// Interpolant used in Vector3.Lerp to smoothly move between points on the path. 
    /// Measures the percentage of the distance travelled.
    /// </summary>
    private float lerpDistance;
    /// <summary>
    /// Timer of how long the enemy has been interpolating between two points.
    /// </summary>
    private float lerpTimer = 0;

    public override void Init(GameObject enemy)
    {
        startPosition = enemy.transform.position;
        lerpTimer = 0;
    }

    /// <summary>
    /// Lerp function to move the enemy towards the target position. Returns true if the action is fully completed.
    /// </summary>
    public override bool Run(GameObject enemy)
    {
        lerpTimer += Time.deltaTime;

        lerpDistance = lerpTimer / moveDuration;
        enemy.transform.position = Vector3.Lerp(startPosition, targetPosition, lerpDistance);

        if (Vector3.Distance(targetPosition, enemy.transform.position) < enemy.GetComponent<Enemy>().stopDistance)
        {
            isCompleted = true;
        }

        return isCompleted;
    }
}

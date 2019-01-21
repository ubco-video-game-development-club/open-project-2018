using UnityEngine;

public abstract class EnemyAction {

    protected bool isCompleted = false;

    public abstract void Init(GameObject enemy);
    public abstract bool Run(GameObject enemy);
}

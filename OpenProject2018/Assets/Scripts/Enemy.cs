using UnityEngine;
using System.Collections.Generic;
using System.Globalization;
using System;

public class Enemy : MonoBehaviour {

    /// <summary>
    /// Text file containing a list of EnemyActions that form the enemy's movement sequence.
    /// </summary>
    public TextAsset movementSequenceFile;
    /// <summary>
    /// How close the player must be to a point on the path before being considered at that point.
    /// </summary>
    public float stopDistance = 0.01f;

    /// <summary>
    /// List of EnemyActions that form the enemy's movement sequence.
    /// </summary>
    private List<EnemyAction> movementSequence;
    /// <summary>
    /// Index of the current step in the enemy's movement sequence.
    /// </summary>
    private int actionIndex;

    private void Start ()
    {
        movementSequence = new List<EnemyAction>();
        ReadMovementSequenceFile();

        actionIndex = 0;
        movementSequence[actionIndex].Init(gameObject);
    }
	
	private void FixedUpdate ()
    {
        bool completed = movementSequence[actionIndex].Run(gameObject);

        if (completed)
        {
            actionIndex++;

            if (actionIndex >= movementSequence.Count)
            {
                Destroy(gameObject);
                return;
            }

            movementSequence[actionIndex].Init(gameObject);
        }
	}

    private void ReadMovementSequenceFile()
    {
        string[] sequence = movementSequenceFile.text.Split(new string[] { Environment.NewLine, " " }, StringSplitOptions.None);
        for (int i = 0; i < sequence.Length; i++)
        {
            string word = sequence[i];
            float x, y, t;
            switch (word)
            {
                case "SPAWN":
                    EnemySpawnAction spawn = new EnemySpawnAction();

                    x = float.Parse(sequence[++i]);
                    y = float.Parse(sequence[++i]);
                    spawn.spawnPosition = new Vector3(x, y, 0);

                    movementSequence.Add(spawn);
                    break;

                case "MOVE":
                    EnemyMovementAction move = new EnemyMovementAction();

                    x = float.Parse(sequence[++i]);
                    y = float.Parse(sequence[++i]);
                    move.targetPosition = new Vector3(x, y, 0);

                    t = float.Parse(sequence[++i]);
                    move.moveDuration = t;

                    movementSequence.Add(move);
                    break;

                case "IDLE":
                    EnemyIdleAction idle = new EnemyIdleAction();

                    t = float.Parse(sequence[++i]);
                    idle.idleDuration = t;

                    movementSequence.Add(idle);
                    break;
            }
        }
    }
}
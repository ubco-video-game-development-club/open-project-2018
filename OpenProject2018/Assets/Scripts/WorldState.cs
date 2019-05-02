using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * Persistent object in level to 
 * control object spawning, etc 
 */

public class WorldState : MonoBehaviour
{
    public GameObject firstEnemy;   //First wave of greenies
    public GameObject shooterEnemy; //The dangerous guy who ruthlessly shoot back

    private void Start()
    { 
        for (int i = 0; i <= 20; i++)
        {
          Invoke("SpawnFirstEnemy", i*0.15f);   //Invoke 20 times for 20 greenies
        }

        //The dangerous guy
        Instantiate(shooterEnemy, new Vector2(999, 999), Quaternion.identity);

    }

    //Spawns a greenie
    void SpawnFirstEnemy()
    {
        Instantiate(firstEnemy, new Vector2(999, 999), Quaternion.identity);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 0);
    }

    void SpawnObject()
    {
        Instantiate(target, new Vector2(999, 999), Quaternion.identity);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrenchSpawnScript : MonoBehaviour
{
    public GameObject trench;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnTrench();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnTrench();
            timer = 0;
        }
    }

    void spawnTrench()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(
            trench,
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation
        );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScripts : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRate;
    private float timer = 0;
    [SerializeField] private float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight), 0), transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScpripts : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRate;
    private float timer = 0;

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
        Instantiate(pipe, transform.position, transform.rotation);
    }
}

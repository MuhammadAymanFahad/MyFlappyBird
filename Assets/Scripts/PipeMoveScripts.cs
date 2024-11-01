using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScripts : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    private float destroyZone = -37;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        checkPipePosition();
    }

    void checkPipePosition()
    {
        if(transform.position.x < destroyZone)
        {
            Destroy(this.gameObject);
        }
    }
}

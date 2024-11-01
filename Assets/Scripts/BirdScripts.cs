using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScripts : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

}

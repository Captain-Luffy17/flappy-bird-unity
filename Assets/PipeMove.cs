using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public float deadZone = -59;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
        transform.position += Vector3.left * speed * Time.deltaTime;  
    }
}

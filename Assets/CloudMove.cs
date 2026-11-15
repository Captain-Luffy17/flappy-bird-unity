using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    public float deadZone = -59;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Debug.Log("Cloud Destroyed");
            Destroy(gameObject);
        }
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

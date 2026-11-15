using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logicScript;
    public bool birdIsAlive = true;
    // Start is called before the first frame update

    public float topLimit = 20f;
    public float bottomLimit = -20f;
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > topLimit|| transform.position.y < bottomLimit)
        {
            logicScript.GameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.GameOver();
        birdIsAlive = false;
    }
}

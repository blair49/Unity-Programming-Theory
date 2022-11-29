using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10f;
    public float boundary;
    public float launchForce = 2.0f;
    public Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.GetInstance().isGameOver)
        {
            MoveLeftRight();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!GameManager.GetInstance().started)
                {
                    GameManager.GetInstance().StartGame();
                    LaunchBall();
                }
            }
        }
    }

    //abstraction
    void MoveLeftRight()
    {
        float input = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += input * speed * Time.deltaTime;
        if (pos.x > boundary)
        {
            pos.x = boundary;
        }
        if (pos.x < -boundary)
        {
            pos.x = -boundary;
        }
        transform.position = pos;
    }

    void LaunchBall()
    {
        float randomDirection = Random.Range(-1.0f, 1.0f);
        Vector3 forceDir = new Vector3(randomDirection, 1, 0);
        forceDir.Normalize();

        ball.transform.SetParent(null);
        ball.AddForce(forceDir * launchForce, ForceMode.VelocityChange);
    }
}

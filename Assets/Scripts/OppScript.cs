using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppScript : MonoBehaviour
{
    public GameObject ball;

    private void Start()
    {
        ball = GameObject.Find("Ball");
    }
    void FixedUpdate()
    {
        transform.position = new Vector3(7.5f, Mathf.Clamp(ball.transform.position.y, -3.81f, 3.81f), 0);
    }
}

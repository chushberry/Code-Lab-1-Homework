using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCamera : MonoBehaviour
{
    GameObject ball;
    Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
        cameraOffset = new Vector3(0, 2, -5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + cameraOffset;
    }
}

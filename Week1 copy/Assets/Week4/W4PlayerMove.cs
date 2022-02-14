using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W4PlayerMove : MonoBehaviour
{
    int moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        // {
        //    gameObject.GetComponent<Rigidbody>().velocity = new Vector3();
        // }

        Move(KeyCode.W, 0, moveSpeed);
        Move(KeyCode.A, 0, -moveSpeed);
        Move(KeyCode.S, -moveSpeed, 0);
        Move(KeyCode.D, moveSpeed, 0);
    }

    void Move(KeyCode key, float xMove, float yMove)
    {
      if (Input.GetKey(key))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(xMove, yMove, 0);
        }
    }
}

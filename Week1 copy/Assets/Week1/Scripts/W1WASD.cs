using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W1WASD : MonoBehaviour
{
    //adding public to the line below makes this number visible in unity
    public float speed = 0.5f;

    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    // Start is called before the first frame update
    // runs once at the start
    void Start()
    {

    }

    // Update is called once per frame
    // runs forever and ever
    void Update()
    {
        //declares newPosition as transform.position
        Vector3 newPosition = transform.position;
        //Debug.Log(newPosition);
        if (Input.GetKey(upKey))
        {
            newPosition.y += speed;

        }
        if (Input.GetKey(leftKey))
        {
            newPosition.x -= speed;

        }
        if (Input.GetKey(downKey))
        {
            newPosition.y -= speed;

        }
        if (Input.GetKey(rightKey))
        {
            newPosition.x += speed;

        }

        // takes the stuff I did with newPosition and puts it back into transform.position
        transform.position = newPosition;
    }

}

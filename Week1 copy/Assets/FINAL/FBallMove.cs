using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBallMove : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f;

    public Rigidbody rb;

    private float xInput;

    private float zInput;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
 void Update()
    {
        // if (Input.GetKey(KeyCode.RightArrow))
        //    transform.position += Time.deltaTime * moveSpeed * Vector3.right;

        // if (Input.GetKey(KeyCode.LeftArrow))
        //    transform.position += Time.deltaTime * moveSpeed * Vector3.left;

        // if (Input.GetKey(KeyCode.UpArrow))
        //     transform.position += Time.deltaTime * moveSpeed * Vector3.forward;

        //  if (Input.GetKey(KeyCode.DownArrow))
        //  transform.position += Time.deltaTime * moveSpeed * Vector3.back;
        Inputs();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }

    private void Inputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

}

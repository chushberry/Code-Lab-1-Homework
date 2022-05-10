using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W10CameraLook : MonoBehaviour
{

    public float sphereRadius = 3f;

    public float zOffset = 10f;

    GameObject heldObj;
    Vector3 objOriginalPos;


    public float rotationSpeed = 2f;

    public float mouseSensitivity = .5f;
    public float clampAngle = 80.0f;
    float rotationX;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 startRot = transform.localRotation.eulerAngles;
        rotationX = startRot.x;
        rotationY = startRot.y;
    }

    // Update is called once per frame
    void Update()
    {
        // start of a ray
        Vector3 eyePosition = transform.position;
        // where the ray is going to go
        Vector3 mousePos = Input.mousePosition;

        // anything you cant see, you cant click bc of this
        mousePos.z = Camera.main.nearClipPlane;

        // uses where my mouse is in the world as opposed to where it is on the screen
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

        // sets the direction of the ray
        Vector3 dir = mouseWorldPos - eyePosition;
        // no stopping point
        dir.Normalize();

        //this will be the raycast
        RaycastHit hitter = new RaycastHit();

        //Debug.DrawLine(eyePosition, dir * 20f, Color.red);

        if (Physics.SphereCast(eyePosition, sphereRadius, dir, out hitter))
        {
            // if youre holding an object
            if(heldObj != null)
                if(heldObj.name == hitter.collider.gameObject.name)
                {
                    Debug.Log("cursor on held object");
                    float xRotate = Input.GetAxis("Mouse X") * rotationSpeed;
                    float yRotate = Input.GetAxis("Mouse Y") * rotationSpeed;

                    heldObj.transform.Rotate(Vector3.up, xRotate);
                    heldObj.transform.Rotate(Vector3.right, yRotate);
                }
            //Debug.Log("hit something");
            //Debug.Log(hitter.collider.gameObject.name);
            if(Input.GetMouseButton(0) && hitter.collider.gameObject.tag == "pickable"&& heldObj == null)
            {
                Debug.Log("can pick up");
                PickUpObject(hitter.collider.gameObject);
            }
        }

        if (Input.GetMouseButton(1) && heldObj != null)
        {
            DropObject();
        }

        MoveCamera();
    }

    void PickUpObject (GameObject obj)
    {
        heldObj = obj;
        objOriginalPos = obj.transform.position;
        obj.transform.SetParent(gameObject.transform);

        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + zOffset);

        obj.transform.position = newPos;
    }

    void DropObject()
    {
        heldObj.transform.SetParent(null);
        heldObj.transform.position = objOriginalPos;

        objOriginalPos = Vector3.zero;
        heldObj = null;
    }

    void MoveCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotationX += mouseY * mouseSensitivity * Time.deltaTime;
        rotationY += mouseX * mouseSensitivity * Time.deltaTime;

        rotationX = Mathf.Clamp(rotationX, -clampAngle, clampAngle);

        //turn those angles back into quaternions
        Quaternion newRotation = Quaternion.Euler(-rotationX, rotationY, 0.0f);
        transform.rotation = newRotation;

    }
}

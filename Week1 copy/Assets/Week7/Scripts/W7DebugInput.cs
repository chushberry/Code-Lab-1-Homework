/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W7DebugInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] gameObjs = GameObject.FindObjectsOfType<GameObject>();
            //foreach counts for the number of times a thing is in an array
            foreach(GameObject obj in gameObjs)
            {
                W7PrintobjectInfo infoPrinter = obj.GetComponent<W7PrintobjectInfo>();
                if(infoPrinter != null)
                {
                    Debug.Log(infoPrinter.MakeDebugString());
                }
            }
        }
    }
}
*/

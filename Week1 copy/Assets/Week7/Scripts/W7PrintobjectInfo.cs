/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W7PrintobjectInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MakeInfoString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string MakeDebugString() {
        return MakeInfoString();
    }
   

    //protected = any class can use this AND any class that extends off of this script
    //virtual = any extended classes will use this function by default if it doesn't recreate its own
    //abstract = an extended class HAS to have a new version of this function
    protected virtual string MakeInfoString()
    {
        string infoString;
        // the \n is a delimiter that splits those up into different lines
        infoString = "Name:" + gameObject.name +
            "\nPosition:" + transform.position.ToString() +
            "\nRotation:" + transform.rotation +
            "\nScale:" + transform.localScale;
        return infoString;
    }
}
*/
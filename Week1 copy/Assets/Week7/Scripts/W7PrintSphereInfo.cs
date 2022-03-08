/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W7PrintSphereInfo : W7PrintobjectInfo
{
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(MakeInfoString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override string MakeInfoString()
    {
        SphereCollider sc = GetComponent<SphereCollider>();
        string sphereInfo = base.MakeInfoString() +
            "\nRadius:" + sc.radius +
            "\nMaterial" + sc.material +
            "\nCenter" + sc.center;
        return sphereInfo;
        //return base.MakeInfoString();
    }
}
*/
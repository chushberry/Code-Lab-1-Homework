/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W7PrintCubeInfo : W7PrintobjectInfo
{
    // Start is called before the first frame update
    void Start()
    {
      //  Debug.Log(MakeInfoString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //override = rewrites OR adds to MakeInfoString()
    // return base.MakeInfoString(); would just return exactly what the parent would have done
    protected override string MakeInfoString()
    {
        BoxCollider bc = GetComponent<BoxCollider>();
        string cubeInfo = base.MakeInfoString() +
            "\nSize:" + bc.size +
            "\nMaterial" + bc.material +
            "\nCenter" + bc.center;
        return cubeInfo;
        //return base.MakeInfoString();
    }
}
*/

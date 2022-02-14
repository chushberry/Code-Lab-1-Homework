using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2UtilScript
{
    // this function gives instructions for how to move a vector and returns a Vector3
    // parameters: starting position, new x pos, new y pos, new z pos
    // static means this can't be changed by other classes - only this class can change it
    public static Vector3 Vector3Modify (Vector3 initVec, float xMod, float ymod, float zMod)
    {
        Vector3 returnVec = new Vector3(initVec.x + xMod,
                                        initVec.y + ymod,
                                        initVec.z + xMod);
        return returnVec;
    }

}

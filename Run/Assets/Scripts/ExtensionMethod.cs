using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod
{
    public static void SetY(this Transform tr, float y)
    {
        Vector3 pos = tr.position;
        pos.y = y;
        tr.position = pos;
    }

}

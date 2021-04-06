using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkLine : MonoBehaviour
{
    GameObject obj;

    private void FixedUpdate()
    {
        obj = new GameObject("CheckPoint");
        obj.tag = "CheckPoint";
        obj.transform.position = this.transform.position;
    }
}
    
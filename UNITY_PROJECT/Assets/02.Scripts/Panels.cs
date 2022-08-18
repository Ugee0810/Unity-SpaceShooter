using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Panels : MonoBehaviour
{
    //enum PanelType
    //{
    //    BlockRight,
    //    BlockLeft,
    //    BlockUp,
    //    Quiz,
    //    Motion_xxx
    //}


    private void Update()
    {
        transform.position += Time.deltaTime * transform.forward * -2;
    }
}

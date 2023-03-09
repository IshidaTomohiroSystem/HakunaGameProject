using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Vector3 p = Camera.main.transform.position;
        //p.y = transform.position.y;
        //transform.LookAt(p);
        transform.transform.eulerAngles = new Vector3(0, 0, 0);
    }
}

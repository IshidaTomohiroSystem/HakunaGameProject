using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LazerDirection : MonoBehaviour
{
    [SerializeField] VisualEffect effect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            effect.SetFloat("Direction", -1);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            effect.SetFloat("Direction", 1);
        }
    }
}

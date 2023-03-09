using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharaBase
{
    private void OnCollisionEnter(Collision collision)
    {
        hp -= 10;
    }
}

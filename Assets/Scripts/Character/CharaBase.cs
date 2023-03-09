using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharaType
{
    None,
    Player,
    Enemey,
}
public abstract class CharaBase : MonoBehaviour
{
    public CharaType charaType;

    public float hp { get; set; }

    public string name { get; set; }

    protected Vector3 position { get; set; }

    protected GameObject attackEffect { get; set; }

}

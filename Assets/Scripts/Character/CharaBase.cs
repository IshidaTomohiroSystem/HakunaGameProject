using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharaType
{
    None,
    Player,
    Enemey,
}
public abstract class CharaBase
{
    protected CharaType charaType;

    protected float hp
    {
        get
        {
            return this.hp;
        }
        set
        {
            this.hp = value;
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }
    }

    protected string name { get; set; }

    protected Vector3 position { get; set; }

    protected GameObject attackEffect { get; set; }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

[CreateAssetMenu(fileName = "CharListData", menuName = "ScriptableObjects/CharListDataAssets")]
public class CharListData : ScriptableObject
{
    public List<CharaObjectData> CharList = new List<CharaObjectData>();
}

[Serializable]
public class CharaObjectData
{
    public GameObject chara;
    public Sprite CharaSprite;
    public string CharaName;
}

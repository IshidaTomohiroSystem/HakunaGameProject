using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

[CreateAssetMenu(fileName = "CharListData", menuName = "ScriptableObjects/CharListDataAssets")]
public class CharListData : ScriptableObject
{
    public List<CharaData> CharList = new List<CharaData>();
}

[Serializable]
public class CharaData
{
    public GameObject chara;
    public Sprite CharaSprite;
}

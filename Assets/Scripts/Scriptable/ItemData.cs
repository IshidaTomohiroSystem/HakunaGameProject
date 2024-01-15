using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemListData", menuName = "ScriptableObjects/ItemListDataAssets")]
public class ItemData : ScriptableObject
{
    public List<ItemObjectData> itemList = new List<ItemObjectData>();
}

[Serializable]
public class ItemObjectData
{
    public GameObject item;
    public Sprite itemSprite;
    public string itemName;
}
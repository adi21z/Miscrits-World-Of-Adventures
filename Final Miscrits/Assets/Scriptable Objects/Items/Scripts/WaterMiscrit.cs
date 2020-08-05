using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Water Miscrit",menuName ="Inventory System/Items/Water")]
public class WaterMiscrit : ItemObject
{
    public void Awake()
    {
        type = ItemType.Water;
    }
}

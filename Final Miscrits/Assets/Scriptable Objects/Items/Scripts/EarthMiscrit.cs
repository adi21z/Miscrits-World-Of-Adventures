using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Earth Miscrit",menuName ="Inventory System/Items/Earth")]
public class EarthMiscrit : ItemObject
{
    public void Awake()
    {
        type = ItemType.Earth;
    }
}

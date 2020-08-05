using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Wind Miscrit",menuName ="Inventory System/Items/Wind")]
public class WindMiscrit : ItemObject
{
    public void Awake()
    {
        type = ItemType.Wind;
    }
}

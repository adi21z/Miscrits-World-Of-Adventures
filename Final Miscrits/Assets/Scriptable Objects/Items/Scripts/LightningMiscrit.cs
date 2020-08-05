using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Lightning Miscrit",menuName ="Inventory System/Items/Lightning")]
public class LightningMiscrit : ItemObject
{
    public void Awake()
    {
        type = ItemType.Lightning;
    }
}

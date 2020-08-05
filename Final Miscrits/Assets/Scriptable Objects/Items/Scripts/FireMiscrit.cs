using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Fire Miscrit",menuName ="Inventory System/Items/Fire")]
public class FireMiscrit : ItemObject
{
    public void Awake()
    {
        type = ItemType.Fire;
    }
}

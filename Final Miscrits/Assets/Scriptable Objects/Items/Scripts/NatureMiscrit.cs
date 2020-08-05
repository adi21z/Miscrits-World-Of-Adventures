using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Nature Miscrit",menuName ="Inventory System/Items/Nature")]
public class NatureMiscrit : ItemObject
{
    public void Awake()
    {
        type = ItemType.Nature;
    }
}

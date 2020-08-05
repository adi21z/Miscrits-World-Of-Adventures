using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Currency",menuName ="Inventory System/Items/Currency")]
public class Currency : ItemObject
{
    private void Awake()
    {
        type = ItemType.Currency;
    }
    
}

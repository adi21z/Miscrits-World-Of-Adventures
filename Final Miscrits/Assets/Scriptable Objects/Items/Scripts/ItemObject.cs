using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
    {
    Fire,Water,Nature,Wind,Earth,Lightning,Currency
}
public abstract class ItemObject : ScriptableObject 
{
    public int Id;
    public Sprite uiMiscritImageDisplay;
    public Sprite uiMiscritElementDisplay;
    public string uiMiscritName;
    public int amount;
    public ItemType type;
    [TextArea(5,10)]
    public string description;
} 
[System.Serializable]
public class Item
{
    public string Name;
    public int Id;
    public int amount;
   
    public Item(ItemObject item)
    {
        Name = item.name;
        Id = item.Id;
        amount = item.amount;
    }
}

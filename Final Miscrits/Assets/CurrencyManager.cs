using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public InventoryObject inventory;
    public TextMeshProUGUI PlatinumText;
    public TextMeshProUGUI PlatinumShopText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i <inventory.Container.Items.Count; i++)
        
            PlatinumText.text = inventory.database.GetItem[inventory.Container.Items[0].item.Id].amount.ToString();
        PlatinumShopText.text = inventory.database.GetItem[inventory.Container.Items[0].item.Id].amount.ToString();

    }
}

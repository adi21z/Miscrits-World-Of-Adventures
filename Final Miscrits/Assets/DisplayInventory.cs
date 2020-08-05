using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public GameObject inventoryPrefab;
    public InventoryObject inventory;
    public List<GameObject> Ifabs = new List<GameObject>();
    //public float X_START;
    //public float Y_START; 
    //public float X_SPACE_BETWEEN_ITEMS;
    //public float Y_SPACE_BETWEEN_ITEMS;
    //public int NUMBER_OF_COLUMNS;
    
    
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
       CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
        UpdateDisplay();
    }
    void UpdateDisplay()
    {
       
        for (int i = 0; i < inventory.Container.Items.Count; i++)
        {
                InventorySlot slot = inventory.Container.Items[i];
                if (!itemsDisplayed.ContainsKey(slot))
                {
                    var obj = Instantiate(inventoryPrefab, Vector2.zero, Quaternion.identity);
                    obj.transform.GetChild(0).GetComponentInChildren<Image>().sprite = inventory.database.GetItem[slot.item.Id].uiMiscritImageDisplay;
                    obj.transform.GetChild(1).GetComponentInChildren<Image>().sprite = inventory.database.GetItem[slot.item.Id].uiMiscritElementDisplay;
                    obj.transform.GetChild(3).GetComponentInChildren<Text>().text = inventory.database.GetItem[slot.item.Id].uiMiscritName;
                //obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    Ifabs.Add(obj);      
                    itemsDisplayed.Add(slot, obj);
                   
                }
            
        }
            
                

                
            

        
    }
    void CreateDisplay()
    {
        for (int i = 0; i <inventory.Container.Items.Count; i++)
        {
               InventorySlot slot = inventory.Container.Items[i];
                var obj = Instantiate(inventoryPrefab, Vector2.zero, Quaternion.identity);
                obj.transform.GetChild(0).GetComponentInChildren<Image>().sprite = inventory.database.GetItem[slot.item.Id].uiMiscritImageDisplay;
                obj.transform.GetChild(1).GetComponentInChildren<Image>().sprite = inventory.database.GetItem[slot.item.Id].uiMiscritElementDisplay;
                obj.transform.GetChild(3).GetComponentInChildren<Text>().text = inventory.database.GetItem[slot.item.Id].uiMiscritName;
                //obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                Ifabs.Add(obj);
                itemsDisplayed.Add(slot, obj);
                
                
           
        }
            


        
    }
   
    //public Vector2 GetPosition(int i)
    //{
        

    //    return new Vector2(X_START + (X_SPACE_BETWEEN_ITEMS*(i %NUMBER_OF_COLUMNS)),Y_START+(-Y_SPACE_BETWEEN_ITEMS*(i/NUMBER_OF_COLUMNS)));
    //}
}

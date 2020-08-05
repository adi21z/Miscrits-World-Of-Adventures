using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMiscritsDisplay : MonoBehaviour
{
    private DisplayInventory displayInventory;
    //private GameObject content;
    // Start is called before the first frame update
    void Start()
    {
        displayInventory = GetComponent<DisplayInventory>();
       // content = Resources.Load<GameObject>("Content") ;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay();
    }
    void UpdateDisplay()
    {
        for (int i = 0; i <displayInventory.Ifabs.Count; i++)
        {
            if(!displayInventory.Ifabs[i].transform.IsChildOf(transform))
            displayInventory.Ifabs[i].transform.SetParent(transform,false);
            displayInventory.Ifabs[i].transform.SetSiblingIndex(i);
        }
        
    }
}

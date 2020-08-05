using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Main4Display : MonoBehaviour,IPointerDownHandler
{
    public MyMiscritsPageButton MMPB;
    public GameObject inventoryScreen1;
    public DisplayInventory DI;
    public GameObject miscrit1, miscrit2, miscrit3, miscrit4;
    private Vector3 addPos1 = new Vector3(63f,60f);
    private Vector3 addPos2 = new Vector3(172f, 60f);
    private Vector3 addPos3 = new Vector3(279f, 60f);
    private Vector3 addPos4 = new Vector3(387f, 60f);
    public void OnPointerDown(PointerEventData eventData)
    {
        
        
        if (MMPB.tap1)
        {
            miscrit1 =Instantiate(gameObject, Vector3.zero, Quaternion.identity);
            DI.Ifabs.Remove(gameObject);
            MMPB.tap1 = false;
        }
        else if (MMPB.tap2)
        {
            miscrit2= Instantiate(gameObject, Vector3.zero, Quaternion.identity);
            DI.Ifabs.Remove(gameObject);
            MMPB.tap2 = false;
        }
        else if (MMPB.tap3)
        {
            miscrit3=Instantiate(gameObject, Vector3.zero, Quaternion.identity);
            DI.Ifabs.Remove(gameObject);
            MMPB.tap3 = false;
        }
        else if (MMPB.tap4)
        {
            miscrit4=Instantiate(gameObject, Vector3.zero, Quaternion.identity);
            DI.Ifabs.Remove(gameObject);
            MMPB.tap4 = false;
        }
        MMPB.Screen1.SetActive(true);
        MMPB.Screen2.SetActive(false);
        if (miscrit1)
        {
            miscrit1.transform.SetParent(MMPB.Screen1.transform, false);
            miscrit1.transform.localPosition = miscrit1.transform.localPosition + addPos1;
        }
        if (miscrit2)
        {
            miscrit2.transform.SetParent(MMPB.Screen1.transform, false);
            miscrit2.transform.localPosition = miscrit2.transform.localPosition + addPos2;
        }
        if (miscrit3)
        {
            miscrit3.transform.SetParent(MMPB.Screen1.transform, false);
            miscrit3.transform.localPosition = miscrit3.transform.localPosition + addPos3;
        }
        if (miscrit4)
        {
            miscrit4.transform.SetParent(MMPB.Screen1.transform, false);
            miscrit4.transform.localPosition = miscrit4.transform.localPosition + addPos4;
        }
        
       
       
        
    }

    // Start is called before the first frame update
    void Start()
    {
        MMPB = GameObject.FindWithTag("scriptsContainer").GetComponent<MyMiscritsPageButton>();
        inventoryScreen1 = GameObject.FindWithTag("Screen1");
        DI = GameObject.FindWithTag("Content").GetComponent<DisplayInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

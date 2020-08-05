using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscritExchangeManager : MonoBehaviour
{
    public Main4Display M4D;
    public GameObject[] topFour= new GameObject[4];
    public MyMiscritsPageButton MMPB;
    public DisplayInventory DI;
    // Start is called before the first frame update

    void Start()
    {
        MMPB = GameObject.FindWithTag("scriptsContainer").GetComponent<MyMiscritsPageButton>();
        DI = GameObject.FindWithTag("Content").GetComponent<DisplayInventory>();
    }
    public void whenMiscritChanged()
    {
        //for (int i = 4; i < (MMPB.Screen1.transform.childCount+4); i++)
        //{
        //    if(!mainFour.Contains(MMPB.Screen1.transform.GetChild(i).gameObject))
        //    mainFour.Add(MMPB.Screen1.transform.GetChild(i).gameObject);
        //}
        if (MMPB.tap1)
        {
            if (topFour[1])
            {
                DI.Ifabs.Add(topFour[1]);
                topFour[1] = null;
            }
            else
            topFour[1] = M4D.miscrit1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        whenMiscritChanged(); 
    }
}

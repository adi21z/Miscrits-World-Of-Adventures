using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptToTag : MonoBehaviour
{


    private GameObject[] clickableObjects;

    // Start is called before the first frame update
    void Start()
    {
        clickableObjects = GameObject.FindGameObjectsWithTag("ClickableBackground");
        for (int i = 0; i < clickableObjects.Length; i++)
        {
            clickableObjects[i].AddComponent<SearchMiscrit>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMiscritsPageButton : MonoBehaviour
{
    public GameObject myMiscritsPanel;
    private GameObject content;
    private RectTransform rt;
    public GameObject Screen1;
    public GameObject Screen2;
    public bool tap1, tap2, tap3, tap4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(myMiscritsPanelActivation());

    }

    // Update is called once per frame
    void Update()
    {
        content = GameObject.FindWithTag("Content");
        rt = content.GetComponent<RectTransform>();

    }
    public void OnClickRightButton()
    {
       if(rt.anchoredPosition.x>-1834.23f)
        rt.anchoredPosition = new Vector2(rt.anchoredPosition.x - 407.7f, rt.anchoredPosition.y);
        
    }
    public void OnClickLeftButton()
    {
        if(rt.anchoredPosition.x <= 1427.37f)
        rt.anchoredPosition = new Vector2(rt.anchoredPosition.x + 407.7f, rt.anchoredPosition.y);
    }
    public void OnClickTap1()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        tap1 = true;
    }
    public void OnClickTap2()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        tap2 = true;
    }
    public void OnClickTap3()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        tap3 = true;
    }
    public void OnClickTap4()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        tap4 = true;
    }

    public IEnumerator myMiscritsPanelActivation()
    {
        yield return new  WaitForSeconds(1);
        myMiscritsPanel.SetActive(false);
    }
    
}


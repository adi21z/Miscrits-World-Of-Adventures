using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicks : MonoBehaviour
{
    public GameObject panel;
    public GameObject myMiscritsPanel;
    //gameUIstart
    public void OnClickMyMiscrits()
    {
        Time.timeScale = 0;
        myMiscritsPanel.SetActive(true);
    }
    public void OnClickTrain()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }
    public void OnClickMiscripedia()
    {

    }
    public void OnClickMiscrit1()
    {

    }
    public void OnClickMiscrit2()
    {

    }
    public void OnClickMiscrit3()
    {

    }
    public void OnClickMiscrit4()
    {

    }
    public void OnClickGoldGem()
    {

    }
    //gameUIEnd

    //trainUistart
    public void OnClickCross()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void OnClickMyMiscritsCross()
    {
        Time.timeScale = 1;
        myMiscritsPanel.SetActive(false);
    }
}

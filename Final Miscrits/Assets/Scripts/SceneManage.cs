using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    public void OnClickHealingChapel()
    {
        SceneManager.LoadScene("HealingChapel");
    }
    public void OnClickReturnFromHealChapel()
    {
        SceneManager.LoadScene("Sunfall Kingdom");
    }
    public void ExitMiscrianForest()
    {
        SceneManager.LoadScene("Sunfall Kingdom");
    }
    public void EnterMiscrianForest()
    {
        SceneManager.LoadScene("MiscrianForest");
    }
    public void OnClickBattleArena()
    {
        SceneManager.LoadScene("BattleArena");
    }
    public void OnClickReturnFromBattleArena()
    {
        SceneManager.LoadScene("Sunfall Kingdom");
    }
    public void OnClickRelicsAndItemShop()
    {
        SceneManager.LoadScene("Items");
    }
    public void OnClickExitRelicsAndItemShop()
    {
        SceneManager.LoadScene("Sunfall Kingdom");
    }
    public void OnClickMagicShop()
    {
        SceneManager.LoadScene("MagicShop");
    }
    public void OnClickExitMagicShop()
    {
        SceneManager.LoadScene("Sunfall Kingdom");
    }
    public void OnClickMiscritShop()
    {
        SceneManager.LoadScene("MiscritShop");
    }
    public void OnClickExitMiscritShop()
    {
        SceneManager.LoadScene("Sunfall Kingdom");
    }
}

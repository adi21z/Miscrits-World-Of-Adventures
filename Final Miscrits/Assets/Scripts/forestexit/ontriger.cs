using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontriger : MonoBehaviour
{
    [HideInInspector]
    public SceneManage sceneManage;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
       sceneManage.ExitMiscrianForest();
    }
}

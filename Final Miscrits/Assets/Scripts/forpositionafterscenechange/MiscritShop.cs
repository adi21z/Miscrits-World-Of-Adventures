﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MiscritShop : MonoBehaviour
{
    private void OnDestroy()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SavedPositionManager.sceneNo = sceneIndex;
    }
}

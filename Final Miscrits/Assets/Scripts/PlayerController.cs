using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector3 mousePosition;
    [SerializeField] float moveSpeed = 0.1f;
    Rigidbody2D player;
    Vector2 position;
    Vector2 spwanposition;
    Vector2 finalposition;

    private void Start()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        player = GetComponent<Rigidbody2D>();
        if (sceneName=="HealingChapel")              //for spawning player in the right position
        {
            position = new Vector2(-4.3f,-4.66f);
        }
       
        if (sceneName == "MiscrianForest")           //for spawning player in the right position
        {
            position = new Vector2(-3.85f, -1.05f);
        }
        if (sceneName == "BattleArena")              //for spawning player in the right position
        {
            position = new Vector2(-0.02f, -6.69f);
        }
        if(sceneName == "Items")
        {
            position = new Vector2(2.22f,-1.54f);               //for spawning player in the right position
        }
        if (sceneName == "MagicShop")
        {
            position = new Vector2(2.6f,-1.77f);               //for spawning player in the right position
        }
        if (sceneName == "MiscritShop")
        {
            position = new Vector2(2.81f, -1.61f);               //for spawning player in the right position
        }
        if (SavedPositionManager.sceneNo == 1)       //scene 1 is healing chapel //this is for spawning player in the right position after coming from different scenes
        {
            position = new Vector2(33.64f, 2.32f);
            SavedPositionManager.sceneNo = 0;
        }
        if (SavedPositionManager.sceneNo == 2)       //scene 2 is Battle Arena //this is for spawning player in the right position after coming from different scenes
        {   position = new Vector2(-8.86f, 17.61f);
            SavedPositionManager.sceneNo = 0;
        }
        if (SavedPositionManager.sceneNo == 3)       //scene 3 is miscrian forest //this is for spawning player in the right position after coming from different scenes
        {
            position = new Vector2(18.5f, 20f);
            SavedPositionManager.sceneNo = 0;
        }
        if (SavedPositionManager.sceneNo ==4)         //scene 4 is items Shop //this is for spawning player in the right position after coming from different scenes
        {
            position = new Vector2(-7.69f,-1.71f);
            SavedPositionManager.sceneNo =0;
        }
        if (SavedPositionManager.sceneNo ==5)         //scene 5 is magic shop //this is for spawning player in the right position after coming from different scenes
        {
            position = new Vector2(-15.06f,-5.02f);
            SavedPositionManager.sceneNo =0;
        }
        if (SavedPositionManager.sceneNo == 6)         //scene 6 is miscrit shop //this is for spawning player in the right position after coming from different scenes
        {
            position = new Vector2(-21.29f, -8.37f);
            SavedPositionManager.sceneNo = 0;
        }
    }
    private void Update()
    {     
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetMouseButton(0))
        {
            Debug.DrawLine(transform.position, mousePosition, Color.red);        
            position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
        finalposition = position;
    }
    private void FixedUpdate()
    {
        player.MovePosition(position);
    }
    

}

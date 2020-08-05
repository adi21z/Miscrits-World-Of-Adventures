
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChange : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;


    [SerializeField] private PlayerController playerController;
    [SerializeField] private Rotation rotation;
    [SerializeField] Animator anim;

    private bool isPressed=true;
    private bool isMouseEnter = false;
    private void Update()
    {
        if (isMouseEnter)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //if the player is not moving or you can say the mouse is not pressed and the button is clicked
                //then this code will run
                rotation.enabled = false;
                playerController.enabled = false;
                anim.Play("idle");
                isPressed = false;
                //Debug.Log("moubtndown");
            }
        }
    }
    public void OnMouseEnter()
    {
        isMouseEnter = true;
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        if (Input.GetMouseButton(0) && isPressed == true)
        {
            //if the player is moving or the mouse button is already hold down then this code will execute
            playerController.enabled = true;
            //Debug.Log("working");
        }
        if (Input.GetMouseButtonUp(0))
        {
            //when the mouse click is released
            isPressed = true;
        }


    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
        playerController.enabled = true;
        rotation.enabled = true;
        //Debug.Log("vs");
        isMouseEnter = false;
    }
    
}
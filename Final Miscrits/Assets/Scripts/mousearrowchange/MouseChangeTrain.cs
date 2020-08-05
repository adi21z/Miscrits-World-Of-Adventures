using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChangeTrain : MonoBehaviour
{

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) {

            OnMouseExit();
       }
    }
}

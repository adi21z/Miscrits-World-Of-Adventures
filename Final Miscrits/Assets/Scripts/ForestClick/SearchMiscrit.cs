using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SearchMiscrit : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color color;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    private Vector3 mousePosition;
    private GameObject instanced;
    private bool temp=true;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = spriteRenderer.color;
        
    }
    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

    }
    private void OnMouseOver()
    {
        cursorTexture = (Texture2D)Resources.Load("cuuu");
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        spriteRenderer.color = new Color(241f / 255f, 235f / 255f, 149f / 255f);
        if (temp == true)
        {
            instanced = Instantiate(Resources.Load("SearchForMiscrits", typeof(GameObject))) as GameObject;
            instanced.transform.position = mousePosition;
            temp = false;
        }
       
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("ForestBattle");
        }
    }
    private void OnMouseExit()
    {
        temp = true;
        spriteRenderer.color = color;
        Cursor.SetCursor(null, hotSpot, cursorMode);
        Destroy(instanced);
    }

}

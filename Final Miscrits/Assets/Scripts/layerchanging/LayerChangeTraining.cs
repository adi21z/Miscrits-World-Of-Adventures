using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerChangeTraining : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private int sortingOrder = 0;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        spriteRenderer.sortingOrder = 1;
        spriteRenderer.sortingLayerName = "player";
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        spriteRenderer.sortingOrder = 1;
        spriteRenderer.sortingLayerName = "background";

    }

}

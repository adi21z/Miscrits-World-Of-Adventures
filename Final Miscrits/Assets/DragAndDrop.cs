using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{

    public RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public Canvas canvas;
    public Vector2 tempPos;
    public bool droppedOnSlot;
    public int id;
    private bool temp = true;
   // public GameObject main4;
    private void Awake()
    {
        Debug.Log("awake");
        canvas = Instantiate(Resources.Load("MyMiscritsCanvas", typeof(Canvas))) as Canvas;
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = false;
       // main4 = GameObject.FindWithTag("main4");
    }

    void Start()
    {
        Debug.Log("start");


    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("onbegindrag");
        canvasGroup.blocksRaycasts = false;
        tempPos = rectTransform.anchoredPosition;
        droppedOnSlot = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("ondrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ondrop");
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        rectTransform.anchoredPosition = eventData.pointerDrag.GetComponent<DragAndDrop>().tempPos;
        eventData.pointerDrag.GetComponent<DragAndDrop>().droppedOnSlot = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("onenddrag");
      //  eventData.pointerDrag.transform.parent = main4.transform;
        if (temp)
        {
            tempPos = eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition;
            canvasGroup.alpha = 1f;
            temp = false;
        }
        canvasGroup.blocksRaycasts = true;
        StartCoroutine(WaitAndPrint());

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("onpointerdown");
    }



    private IEnumerator WaitAndPrint()
    {
        Debug.Log("ienujmerator");
        yield return new WaitForEndOfFrame();
        if (!droppedOnSlot)
            rectTransform.anchoredPosition = tempPos;
    }
}

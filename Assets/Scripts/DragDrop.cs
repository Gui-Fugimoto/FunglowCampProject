using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private RectTransform _transform;

    [SerializeField] private Canvas canvas;

    [SerializeField] private CanvasGroup canvasGroup;
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.5f;
        canvasGroup.blocksRaycasts=false;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData  eventData)
    {
        _transform.anchoredPosition+=eventData.delta/ canvas.scaleFactor;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Apertou");
    }
}

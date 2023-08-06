using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform m_RectTransform;
    private Image item;

    private void Awake()
    {
        m_RectTransform= GetComponent<RectTransform>();
        item= GetComponent<Image>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        item.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta*3.2f;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       item.raycastTarget = true;
    }
}

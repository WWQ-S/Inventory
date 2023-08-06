using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    public Image slot;

    public int itemID_InSlot;
    
    public void OnDrop(PointerEventData eventData)
    {        
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.transform.position = new Vector3 (slot.GetComponent<Transform>().position.x, slot.GetComponent<Transform>().position.y, 10);
            itemID_InSlot = eventData.pointerDrag.GetComponent<Item>().ID;
        }                
    }
}

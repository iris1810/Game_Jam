using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

public class Grab : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler
{   
    private Vector3 offset;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("On begin drag");
    }

    public void OnDrag (PointerEventData eventData)
    {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(eventData.position);
        mouseWorld.z =0f;
        transform.position = mouseWorld + offset; 
        Debug.Log("OnDrag");
        
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        Debug.Log("EndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(eventData.position);
        mouseWorld.z =0f;
        offset = transform.position - mouseWorld;

        // offset is the different between mouse and object you click
        Debug.Log("OnPointerDown");

    }
}

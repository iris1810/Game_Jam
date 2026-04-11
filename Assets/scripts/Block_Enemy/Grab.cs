using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

public class Grab : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler
{   
    private Vector3 offset;
    private bool isInhouseZone = false;
    private SpriteRenderer sprite;

    [SerializeField] private Transform houseTarget;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("On begin drag");

        if (sprite != null)
        {
            Color colorTemp = sprite.color;
            colorTemp.a = 0.6f;
            sprite.color = colorTemp;
        }
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
        Debug.Log("OnEndDrag");
        
        if (sprite != null)
        {
            Color colorTemp = sprite.color;
            colorTemp.a = 1f;
            sprite.color = colorTemp;
        }

        if (isInhouseZone && houseTarget != null)
        {
            transform.position = houseTarget.position;
            Debug.Log("Dropped into house");

            // GetComponent<Collider2D>().enabled = false;
            // enabled = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(eventData.position);
        mouseWorld.z =0f;
        offset = transform.position - mouseWorld;

        // offset is the different between mouse and object you click
        Debug.Log("OnPointerDown");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("House"))
        {
            isInhouseZone = true;
            Debug.Log("Enter House Zone");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("House"))
        {
            isInhouseZone = false;
            Debug.Log("Exit house Zone");
        }
    }
}

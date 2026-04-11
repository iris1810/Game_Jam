using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;

public class Grab : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler
{   
    private Vector3 offset;
    private Vector3 fallBackPosition;

    private SpriteRenderer sprite;
    private Camera mainCamera;
    private HouseSlot currentHouse;
    private HouseSlot previousHouse;

    [SerializeField] private LayerMask houseLayer;


    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        mainCamera = Camera.main;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("On begin drag");

        previousHouse = currentHouse;
        //save the preivous position
        fallBackPosition = transform.position;

        if (sprite != null)
        {
            Color colorTemp = sprite.color;
            colorTemp.a = 0.6f;
            sprite.color = colorTemp;
        }
        if (currentHouse != null)
        {
            currentHouse.ClearEnemy();
            currentHouse = null;
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
        //check for point have any colision with layer hosue
        Collider2D hit = Physics2D.OverlapPoint(transform.position, houseLayer);

        if (hit != null)
        {
            HouseSlot house = hit.GetComponent<HouseSlot>();
            if (house != null && !house.IsOccupied())
            {
                transform.position = house.transform.position;
                house.SetEnemy(this);
                currentHouse = house;
                Debug.Log("Dropped into house");
            }
            else
            {
                ReturnBack();
            }
        }
    }

    public void ReturnBack()
    {
        transform.position = fallBackPosition;
        if (previousHouse != null)
        {
            currentHouse = previousHouse;
            previousHouse.SetEnemy(this);
        }
        Debug.Log("Return Back");
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

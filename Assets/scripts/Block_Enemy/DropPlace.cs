using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlace : MonoBehaviour,IDropHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public  void OnDrop (PointerEventData eventData)
    {
        Debug.Log("OnDrop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

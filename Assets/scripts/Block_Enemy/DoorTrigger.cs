using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private DoorController doorController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D( Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched the door");
        
            if (doorController != null)
                {
                    doorController.TryWin();
                }
    }
    }
}

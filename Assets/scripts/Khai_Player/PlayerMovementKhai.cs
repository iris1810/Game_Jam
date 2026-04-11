using UnityEngine;

public class PlayerMovementKhai : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //get input
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Verticlal"); 

    }
    void FixedUpdated()
    {
        //actual movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }   
}

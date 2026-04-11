using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    
    private float Y_LIMIT= 8;
    private float X_LIMIT=8;
    private playerInputs input;
        void Start()
    {
        input=new();
        input.Enable();
        input.playerActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
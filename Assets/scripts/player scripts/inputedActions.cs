using UnityEngine;

public class inputedActions : MonoBehaviour
{
    public static inputedActions Instance {get; private set;}
    public PlayerInputs.PlayerActionsActions inputs;
  

    private void Awake()
    {
        Instance = this;
        inputs= new();
        inputs.Enable();
        //inputs.Standard.Enable();

    } 
    
    public void DisableInput()
    {
        inputs.Disable();
    }

    public void EnableInput()
    {
        inputs.Enable();
    }
}
using UnityEngine;

public class inputedActions : MonoBehaviour
{
    public static inputedActions Instance {get; private set;}
    public playerInputs.playerActions input;

    private void Awake()
    {
        Instance = this;
        var inputs= new playerActions();
        inputs.Enable();
        input= inputs.playerActions;
        input.Enable();

    } 
    
    public void disableInput()
    {
        input.Disable();
    }

    public void enableInput()
    {
        input.Enable();
    }
}
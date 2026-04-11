using UnityEngine;

public class inputedActions : MonoBehaviour
{
<<<<<<< Updated upstream
    public static inputedActions Instance {get; private set;}
    public PlayerInputs.PlayerActionsActions input;

    private void Awake()
    {
        Instance = this;
        var inputs= new PlayerInputs();
        inputs.Enable();
        input= inputs.playerActions;
        input.Enable();

=======
    //public static inputActions Instance {get; private set;}
    //public Plyerinput.playerActions input;

    private void Awake()
    {
       // Instance = this;
        //var inputs= new 
>>>>>>> Stashed changes
    } 
    
    public void DisableInput()
    {
        input.Disable();
    }

    public void EnableInput()
    {
        input.Enable();
    }
}
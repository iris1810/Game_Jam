using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private HouseSlot[] houses;
    [SerializeField] private GameObject levelUpImage;
    
    public bool AllHousesFilled()
    {
        foreach (HouseSlot house in houses)
        {
            if (house == null || !house.IsOccupied())
            {
                return false;
            }
        }
        return true;
    }

    public void TryWin()
    {
        if (AllHousesFilled())
        {
            if (levelUpImage != null)
            {
                levelUpImage.SetActive(true);
            }
        }else
        {
            Debug.Log("Not enough enemies in houses yet.");
        }
    }

}

using UnityEngine;

public class HouseSlot : MonoBehaviour
{
    public Grab currentEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // check for current use of house, true if house have enemy 
    public bool IsOccupied()
    {
        return currentEnemy != null;
    }

    public void SetEnemy (Grab enemy)
    {
        currentEnemy = enemy;
    }

    public void ClearEnemy()
    {
        currentEnemy = null;
    }

    
}

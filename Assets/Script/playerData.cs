using TMPro;
using UnityEngine;

public class playerData : MonoBehaviour
{
    public float coins = 0;
    public ConditionalButton conditionalButton;
    
    public void Awake()
    {
        coins = 0;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
    }

    public bool SpendCoins(int amount)
    {
        if(coins >= amount)
        {
            coins -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SpendCoinsButton()
    {
        coins -= conditionalButton.getNextButtonCost();
        conditionalButton.IncraseCost();
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConditionalButton : MonoBehaviour
{
    public Button moneyButton;
    public int cost = 10;
    public playerData playerData;
    public TextMeshProUGUI costText;

    private void Start()
    {
        costText.text = "cursor: " +  cost;
    }


    private void Update()
    {
        if(playerData.coins >= cost)
        {
            moneyButton.interactable = true;
        }
        else
        {
            moneyButton.interactable = false;
        }
    }

    public int getNextButtonCost()
    {
        return cost;

    }

    public void IncraseCost()
    {
       float newCost = cost * 1.15f;
       cost = Mathf.RoundToInt(newCost);
        costText.text = "cursor: " + cost;
    }
}

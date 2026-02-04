using UnityEngine;
using UnityEngine.UI;

public class WinButton : MonoBehaviour
{
    public Button winButton;
    public int win = 400;
    public playerData playerData;
    public GameObject youWinText;

    public void Awake()
    {
        youWinText.SetActive(false);
    }



    private void Update()
    {
        if (playerData.coins >= win)
        {
            winButton.interactable = true;
            
        }
        else
        {
            winButton.interactable = false;
               
           
        }
    }

    public void youWin()
    {
        youWinText.SetActive(true);
    }
}

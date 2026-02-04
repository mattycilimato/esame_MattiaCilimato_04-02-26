using TMPro;
using UnityEngine;

public class Ui_manager : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public playerData playerData;

    private void Update()
    {
        if(playerData  != null && coinsText != null)
        {
            coinsText.text = "biscotti: " + Mathf.FloorToInt(playerData.coins);
        }
    }
}

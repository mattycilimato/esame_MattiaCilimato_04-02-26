using TMPro;
using UnityEngine;

public class Persecond : MonoBehaviour
{

    public TextMeshProUGUI perSecondText;
    public Spawner_manager spawner_Manager;

    private void Update()
    {
        if (spawner_Manager != null && perSecondText != null)
        {
            perSecondText.text = "per second: " + spawner_Manager.perSecond;
        }
    }
}

using UnityEngine;

public class Slotrotate : MonoBehaviour
{
    public GameObject slotContainer;


    public void Update()
    {
        SlotRotation();
    }


    public void SlotRotation()
    {
        slotContainer.transform.Rotate(0, 0 , Time.deltaTime * 10);
    }
}

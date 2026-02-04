using UnityEngine;

public class RayCaster_manager : MonoBehaviour
{
    public GameObject cookieClikable;
    public playerData playerData;
    public LayerMask layerMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, 500, layerMask);
            if(hit.collider != null)
            {
                playerData.coins += 1;
                Debug.Log("colpito");
            }
        }
    }
}

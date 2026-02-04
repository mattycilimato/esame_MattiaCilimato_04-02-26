using System.Collections.Generic;
using UnityEngine;

public class Spawner_manager : MonoBehaviour
{
    public GameObject spawnPrefab;
    public List<Slots> slots = new List<Slots>();
    public playerData playerData;
    public float coinsGenerator = 0.4f;
    int cursorsAmount = 0;
    public float perSecond = 0;

    float timer;
    public void spawnerPrefab()
    {
        foreach(Slots slot in slots)
        {
            if (!slot.IsOccupied)
            {
                 
                GameObject cursor =   Instantiate(spawnPrefab, slot.transform.position, Quaternion.identity, slot.transform);
                cursorsAmount++;
                perSecond = cursorsAmount * coinsGenerator;
                slot.IsOccupied = true;
                break;
            }
            
        }
    }

    private void Update()
    {
        if (playerData == null) return;
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0f;
            playerData.coins += perSecond ;
        }
    }
}

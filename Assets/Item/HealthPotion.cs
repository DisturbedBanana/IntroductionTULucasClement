using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    [SerializeField] int _healvalue;

    public override void OnItemPickup(GameObject player)
    {
        player.GetComponent<EntityHealth>().Heal(_healvalue);
        Debug.Log("picked up health potion");
        Destroy(this.gameObject);
    }
}

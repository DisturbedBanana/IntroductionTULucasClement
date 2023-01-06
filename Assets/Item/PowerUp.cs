using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    public override void OnItemPickup(GameObject player)
    {
        player.GetComponent<EntityHealth>().MaxHPUp();
        Destroy(this.gameObject);
    }
}

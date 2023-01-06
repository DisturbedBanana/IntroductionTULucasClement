using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    [SerializeField] int _goldValue;

    public override void OnItemPickup(GameObject player)
    {
        Debug.Log("itempickup");
        player.GetComponent<EntityGold>().AddGold(_goldValue);
        Destroy(this.gameObject);
    }
}
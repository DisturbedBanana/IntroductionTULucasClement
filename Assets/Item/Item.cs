using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnItemPickup(collision.gameObject);
        }
    }

    public virtual void OnItemPickup(GameObject player)
    {
        Debug.Log("Item picked up");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _dmg = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("breakable"))
        {

            other.gameObject.GetComponentInParent<EntityHealth>().TakeDamage(_dmg);
        }
    }
}

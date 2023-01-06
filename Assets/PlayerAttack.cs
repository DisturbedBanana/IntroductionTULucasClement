using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using NaughtyAttributes;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject _sword;
    private bool _isAttacking = false;
    private Collider _swordCollider;
    [SerializeField] InputActionReference _onAttack;
    // Start is called before the first frame update
    void Start()
    {
        _swordCollider = _sword.GetComponent<BoxCollider>();
        _swordCollider.enabled = false;
        _onAttack.action.started += OnAttack; 

    }

    private void OnAttack(InputAction.CallbackContext obj)
    {
        if(_isAttacking == false)
        {
            _isAttacking = true;
            _swordCollider.enabled = true;
            StartCoroutine(SwordCoroutine());
        }

    }

    private void OnDestroy()
    {
        _onAttack.action.started -= OnAttack;
    }
   
    private IEnumerator SwordCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        _swordCollider.enabled = false;
        _isAttacking = false;



    }

}
